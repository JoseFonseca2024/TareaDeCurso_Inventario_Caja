using BosquejoProyecto1.Class;
using BosquejoProyecto1.Forms.FormsFacturación;


namespace BosquejoProyecto1.Forms
{
    public partial class FormFacturación : Form
    {
        private readonly FormService _formService = new FormService();
        private readonly FacturaService _facturaService;
        HttpClient _client = new HttpClient();
        private readonly string url = "https://localhost:7064/api/Facturas";

        public FormFacturación()
        {
            InitializeComponent();
            _formService.CambiodeColor(lblExit);
            _formService.CerrarConValidación(lblExit, this);

            _facturaService = new FacturaService(
                txtId,
                txtNombre,
                txtPrecio,
                numCantidad,
                dgvFactura,
                lblTotal);

        }

        private async void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                string textoTotal = lblTotal.Text.Replace("Total: C$", "").Trim();

                if (string.IsNullOrEmpty(textoTotal))
                {
                    MessageBox.Show("No ha agregado ningún producto. Agregue producto por favor.");
                    return;
                }

                if (!decimal.TryParse(textoTotal, out decimal totalDecimal))
                {
                    MessageBox.Show("El total no tiene un formato válido.");
                    return;
                }

                var form = new FormsPago(totalDecimal);
                form.ShowDialog();

                await _facturaService.CrearFacturaAsync(_client, url);
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Error en proceso");
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            _facturaService.AbrirBuscadorProducto();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text) || !string.IsNullOrEmpty(txtNombre.Text) || !string.IsNullOrEmpty(txtPrecio.Text))
            {
                _facturaService.AgregarProducto();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvFactura.CurrentRow != null)
            {
                // Obtener el detalle que corresponde a la fila seleccionada
                var detalleSeleccionado = dgvFactura.CurrentRow.DataBoundItem as DetalleFacturaTemp;

                if (detalleSeleccionado != null)
                {
                    // Quitar el detalle de la lista interna de FacturaService
                    _facturaService.QuitarDetalle(detalleSeleccionado);

                    // Actualizar la tabla y el total
                    _facturaService.ActualizarVista();
                }
            }
        }
    }
}
