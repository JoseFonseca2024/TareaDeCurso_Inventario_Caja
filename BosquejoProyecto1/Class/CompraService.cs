using BosquejoProyecto1.DTO_s;
using BosquejoProyecto1.DTO_s.Producto;
using System.Net.Http.Json;

namespace BosquejoProyecto1.Class
{
    public class CompraService
    {
        private readonly ProductoService _productoService;

        // Lista temporal de detalles para evitar que se registren de un solo
        private readonly List<DetalleCompraREAD> _detallesActuales = new();

        public IReadOnlyList<DetalleCompraREAD> DetallesActuales => _detallesActuales.AsReadOnly();

        private readonly string _urlProducto = "https://localhost:7064/api/Productoes";

        public CompraService(ProductoService productoService)
        {
            _productoService = productoService;
        }

        public Task AgregarProductoaCompra(
            ComboBox cmbExistencia,
            TextBox txtID,
            TextBox txtNombre,
            TextBox txtCosto,
            TextBox txtPrecio,
            NumericUpDown numUnidades,
            DataGridView dgvCompra,
            Label lblTotal)
        {
            if (cmbExistencia.SelectedItem == null)
            {
                MessageBox.Show("Seleccione si el producto es nuevo o registrado.");
                return Task.CompletedTask;
            }

            string tipo = cmbExistencia.SelectedItem.ToString();
            int cantidad = (int)numUnidades.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que cero.");
                return Task.CompletedTask;
            }

            if (!decimal.TryParse(txtCosto.Text, out decimal costoUnit) || !decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Costo o precio no válidos.");
                return Task.CompletedTask;
            }

            if (costoUnit <= 0 || precio <= 0)
            {
                MessageBox.Show("Los campos de costo y precio deben ser mayores que 0.");
                return Task.CompletedTask;
            }

            DetalleCompraREAD detalle;

            if (tipo == "Nuevo")
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Ingrese el nombre del producto nuevo.");
                    return Task.CompletedTask;
                }

                detalle = new DetalleCompraREAD
                {
                    ProductoID = 0, // Se asignará al confirmar
                    NombreProducto = txtNombre.Text.Trim(),
                    Cantidad = cantidad,
                    CostoUnitario = costoUnit,
                    IVAUnitario = costoUnit * 0.15m
                };
            }
            else // Registrado
            {
                if (!int.TryParse(txtID.Text, out int id))
                {
                    MessageBox.Show("ID de producto no válido.");
                    return Task.CompletedTask;
                }

                // Guardás solo el ID para usarlo luego
                detalle = new DetalleCompraREAD
                {
                    ProductoID = id,
                    NombreProducto = txtNombre.Text.Trim(),
                    Cantidad = cantidad,
                    CostoUnitario = costoUnit,
                    IVAUnitario = costoUnit * 0.15m
                };
            }

            detalle.Total = (detalle.CostoUnitario + detalle.IVAUnitario) * detalle.Cantidad;

            _detallesActuales.Add(detalle);

            RefrescarGrid(dgvCompra);
            CalcularTotalFactura(dgvCompra, lblTotal);

            return Task.CompletedTask;
        }



        private void RefrescarGrid(DataGridView dgvCompra)
        {
            dgvCompra.DataSource = null;
            dgvCompra.DataSource = _detallesActuales;
        }

        public void CalcularTotalFactura(DataGridView dgv, Label lbl)
        {
            decimal total = _detallesActuales.Sum(d => d.Total);
            lbl.Text = $"Total: C$ {total:N2}";
        }

        public void ActualizarProductoEnFactura(
            TextBox txtNombre,
            TextBox txtCosto,
            NumericUpDown numUnidades,
            DataGridView dgvCompra,
            Label lblTotal)
        {
            if (dgvCompra.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila para actualizar.");
                return;
            }

            int index = dgvCompra.CurrentRow.Index;

            if (!decimal.TryParse(txtCosto.Text, out decimal nuevoCosto))
            {
                MessageBox.Show("Costo no válido.");
                return;
            }

            var detalle = _detallesActuales[index];

            detalle.NombreProducto = txtNombre.Text.Trim();
            detalle.CostoUnitario = nuevoCosto;
            detalle.Cantidad = (int)numUnidades.Value;
            detalle.IVAUnitario = nuevoCosto * 0.15m;
            detalle.Total = (detalle.CostoUnitario + detalle.IVAUnitario) * detalle.Cantidad;

            RefrescarGrid(dgvCompra);
            CalcularTotalFactura(dgvCompra, lblTotal);

            MessageBox.Show("Producto actualizado correctamente.");
        }

        public void EliminarProductoDeFactura(DataGridView dgvCompra, Label lblTotal)
        {
            if (dgvCompra.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
                return;
            }

            int index = dgvCompra.CurrentRow.Index;
            _detallesActuales.RemoveAt(index);

            RefrescarGrid(dgvCompra);
            CalcularTotalFactura(dgvCompra, lblTotal);

            MessageBox.Show("Producto eliminado de la factura.");
        }

        public async Task ConfirmarCompraAsync(
             DataGridView dgvCompra,
             Label lblTotal,
             HttpClient client,
             string comprasUrl,
             string productosUrl,
             decimal saldoCaja)
        {
            if (_detallesActuales.Count == 0)
            {
                MessageBox.Show("No hay productos en la factura.");
                return;
            }

            decimal totalCompra = _detallesActuales.Sum(d => d.Total);

            if (totalCompra > saldoCaja)
            {
                MessageBox.Show("No hay suficiente dinero en caja para realizar esta compra.", "Saldo insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Crear productos nuevos (ProductoID == 0)
            foreach (var detalle in _detallesActuales.Where(d => d.ProductoID == 0).ToList())
            {
                var nuevoProductoDto = new ProductoCREATE
                {
                    NombreProducto = detalle.NombreProducto,
                    CostoProducto = detalle.CostoUnitario,
                    PrecioConIVA = detalle.CostoUnitario * 1.15m,
                    Cantidad = detalle.Cantidad,
                    FechaIngreso = DateTime.Now
                };

                var response = await client.PostAsJsonAsync(productosUrl, nuevoProductoDto);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Error al crear el producto nuevo: {detalle.NombreProducto}");
                    return; // aborta la compra si falla crear producto nuevo
                }

                var productoCreado = await response.Content.ReadFromJsonAsync<ProductoREAD>();

                if (productoCreado == null)
                {
                    MessageBox.Show($"Error al obtener producto creado: {detalle.NombreProducto}");
                    return;
                }

                // Actualiza el ProductoID en el detalle para usarlo luego en la compra
                detalle.ProductoID = productoCreado.ProductoID;
            }

            // 2. Actualizar stock de productos existentes
            foreach (var detalle in _detallesActuales.Where(d => d.ProductoID != 0))
            {
                // Traer producto actual
                var productoResp = await client.GetAsync($"{productosUrl}/{detalle.ProductoID}");
                if (!productoResp.IsSuccessStatusCode)
                {
                    MessageBox.Show($"No se encontró el producto ID {detalle.ProductoID} para actualizar.");
                    return;
                }

                var producto = await productoResp.Content.ReadFromJsonAsync<ProductoREAD>();
                if (producto == null)
                {
                    MessageBox.Show($"Error al leer producto ID {detalle.ProductoID} para actualizar.");
                    return;
                }

                // Actualizar cantidad sumando la compra
                var productoUpdate = new ProductoUPDATE
                {
                    NombreProducto = producto.NombreProducto,
                    CostoProducto = producto.CostoProducto,
                    PrecioConIVA = producto.PrecioConIVA,
                    Cantidad = producto.Cantidad + detalle.Cantidad
                };

                var putResp = await client.PutAsJsonAsync($"{productosUrl}/{detalle.ProductoID}", productoUpdate);
                if (!putResp.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Error al actualizar stock del producto {producto.NombreProducto}");
                    return;
                }
            }

            // 3. Crear compra con detalles (ya con IDs correctos)
            var compraDto = new CompraCREATE
            {
                Fecha = DateTime.Now,
                Detalles = _detallesActuales.Select(d => new DetalleCompraCREATE
                {
                    ProductoID = d.ProductoID,
                    Cantidad = d.Cantidad
                }).ToList()
            };

            var compraResp = await client.PostAsJsonAsync(comprasUrl, compraDto);
            if (!compraResp.IsSuccessStatusCode)
            {
                MessageBox.Show("Error al registrar la compra.");
                return;
            }

            // 4. Limpiar UI y lista temporal
            MessageBox.Show("Compra registrada correctamente.");
            _detallesActuales.Clear();
            dgvCompra.DataSource = null;
            lblTotal.Text = "Total: C$ 0.00";

            // 5. Refrescar productos en la UI
            var productos = await client.GetFromJsonAsync<List<ProductoREAD>>(productosUrl);
            
        }


    }
}
