using BosquejoProyecto1.DTO_s;
using BosquejoProyecto1.DTO_s.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

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

        public async Task AgregarProductoaCompra(
                ComboBox cmbExistencia,
                TextBox txtID,
                TextBox txtNombre,
                TextBox txtCosto,
                NumericUpDown numUnidades,
                DataGridView dgvCompra,
                Label lblTotal,
                HttpClient client)
        {
            if (cmbExistencia.SelectedItem == null)
            {
                MessageBox.Show("Seleccione si el producto es nuevo o registrado.");
                return;
            }

            string tipo = cmbExistencia.SelectedItem.ToString();
            int cantidad = (int)numUnidades.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que cero.");
                return;
            }

            if (!decimal.TryParse(txtCosto.Text, out decimal costoUnit))
            {
                MessageBox.Show("Costo no válido.");
                return;
            }

            DetalleCompraREAD detalle;

            if (tipo == "Nuevo")
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Ingrese el nombre del producto nuevo.");
                    return;
                }

                // Crear el producto nuevo vía API
                var nuevoProducto = new ProductoCREATE
                {
                    NombreProducto = txtNombre.Text.Trim(),
                    CostoProducto = costoUnit,
                    PrecioConIVA = costoUnit * 1.15m, // Asume que el precio incluye IVA, puedes ajustar
                    Cantidad = 0, // No aumentas stock aún, solo creas producto
                    FechaIngreso = DateTime.Now
                };

                var response = await client.PostAsJsonAsync(_urlProducto, nuevoProducto);
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error al crear el producto nuevo.");
                    return;
                }

                var productoCreado = await response.Content.ReadFromJsonAsync<ProductoREAD>();

                if (productoCreado == null)
                {
                    MessageBox.Show("Error al obtener producto creado.");
                    return;
                }

                detalle = new DetalleCompraREAD
                {
                    ProductoID = productoCreado.ProductoID,
                    NombreProducto = productoCreado.NombreProducto,
                    Cantidad = cantidad,
                    CostoUnitario = productoCreado.CostoProducto,
                    IVAUnitario = productoCreado.CostoProducto * 0.15m
                };
            }
            else // Registrado
            {
                if (!int.TryParse(txtID.Text, out int id))
                {
                    MessageBox.Show("ID de producto no válido.");
                    return;
                }

                var producto = await client.GetFromJsonAsync<ProductoREAD>($"{_urlProducto}/{id}");
                if (producto == null)
                {
                    MessageBox.Show("Producto no encontrado.");
                    return;
                }

                detalle = new DetalleCompraREAD
                {
                    ProductoID = producto.ProductoID,
                    NombreProducto = producto.NombreProducto,
                    Cantidad = cantidad,
                    CostoUnitario = producto.CostoProducto,
                    IVAUnitario = producto.CostoProducto * 0.15m
                };
            }

            detalle.Total = (detalle.CostoUnitario + detalle.IVAUnitario) * detalle.Cantidad;

            _detallesActuales.Add(detalle);

            // Refrescar el DataGridView y total
            RefrescarGrid(dgvCompra);
            CalcularTotalFactura(dgvCompra, lblTotal);
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
            string productosUrl)
        {
            if (_detallesActuales.Count == 0)
            {
                MessageBox.Show("No hay productos en la factura.");
                return;
            }

            var dto = new CompraCREATE
            {
                Fecha = DateTime.Now,
                Detalles = _detallesActuales.Select(d => new DetalleCompraCREATE
                {
                    ProductoID = d.ProductoID,
                    Cantidad = d.Cantidad
                }).ToList()
            };

            var resp = await client.PostAsJsonAsync(comprasUrl, dto);
            if (resp.IsSuccessStatusCode)
            {
                MessageBox.Show("Compra registrada correctamente.");
                _detallesActuales.Clear();
                dgvCompra.DataSource = null;
                lblTotal.Text = "Total: C$ 0.00";

                // Refrescar productos (cargar desde API)
                var productos = await client.GetFromJsonAsync<List<ProductoREAD>>(productosUrl);
                RefrescarGrid(dgvCompra);

            }
            else
            {
                MessageBox.Show("Error al registrar la compra.");
            }
        }
    }
}