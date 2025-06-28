using BosquejoProyecto1.DTO_s;
using BosquejoProyecto1.Forms.FormsInvetario;
using System.Net.Http.Json;

namespace BosquejoProyecto1.Class
{
    public class FacturaService
    {
        private readonly TextBox _txtID;
        private readonly TextBox _txtNombre;
        private readonly TextBox _txtPrecio;
        private readonly NumericUpDown _numCantidad;

        private readonly DataGridView _dgvFactura;
        private readonly Label _lblTotal;
        private readonly List<DetalleFacturaTemp> _detalles = new();



        public FacturaService(TextBox txtID, TextBox txtNombre, TextBox txtPrecio, NumericUpDown numCantidad, DataGridView dgvFactura, Label lblTotal)
        {
            _txtID = txtID;
            _txtNombre = txtNombre;
            _txtPrecio = txtPrecio;
            _numCantidad = numCantidad;
            _dgvFactura = dgvFactura;
            _lblTotal = lblTotal;
        }

        public void AbrirBuscadorProducto()
        {
            var buscador = new FormStock();

            buscador.ProductoSeleccionado += producto =>
            {
                _txtID.Text = producto.ProductoID.ToString();
                _txtNombre.Text = producto.NombreProducto;
                _txtPrecio.Text = producto.PrecioConIVA.ToString("N2");
                _numCantidad.Value = producto.Cantidad;
            };

            buscador.ShowDialog();
        }

        public void AgregarProducto()
        {
            if (string.IsNullOrWhiteSpace(_txtNombre.Text) || string.IsNullOrWhiteSpace(_txtPrecio.Text))
            {
                MessageBox.Show("Debe seleccionar un producto válido.");
                return;
            }

            int.TryParse(_txtID.Text, out int productoID);
            decimal.TryParse(_txtPrecio.Text, out decimal precio);
            int cantidad = (int)_numCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que cero.");
                return;
            }

            var detalle = new DetalleFacturaTemp
            {
                ProductoID = productoID,
                NombreProducto = _txtNombre.Text,
                PrecioUnitario = precio,
                Cantidad = cantidad,
                Subtotal = precio * cantidad
            };

            _detalles.Add(detalle);
            CargarDatos();
        }

        private void CargarDatos()
        {
            _dgvFactura.DataSource = null;
            _dgvFactura.DataSource = _detalles;

            decimal total = _detalles.Sum(d => d.Subtotal);
            _lblTotal.Text = $"Total: C$ {total:N2}";
        }

        public async Task CrearFacturaAsync(HttpClient client, string url)
        {
            var detalles = new List<DetalleFacturaCREATE>();
            decimal subtotal = 0;

            foreach (DataGridViewRow row in _dgvFactura.Rows)
            {
                if (row.IsNewRow) continue;

                int productoID = Convert.ToInt32(row.Cells["ProductoID"].Value);
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                decimal precio = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);

                detalles.Add(new DetalleFacturaCREATE
                {
                    ProductoID = productoID,
                    Cantidad = cantidad,

                });

                subtotal += precio * cantidad;
            }

            decimal iva = subtotal * 0.15m;
            decimal total = subtotal + iva;

            var factura = new FacturaCREATE
            {
                Fecha = DateTime.Now,
                Detalles = detalles
            };

            var response = await client.PostAsJsonAsync(url, factura);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Factura registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _lblTotal.Text = "Total: C$0.00";
            }
            else
            {
                MessageBox.Show("Error al registrar la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void QuitarDetalle(DetalleFacturaTemp detalle)
        {
            _detalles.Remove(detalle);
        }

        public void ActualizarVista()
        {
            CargarDatos(); // O el método que uses para refrescar la vista y el total
        }
    }
}
