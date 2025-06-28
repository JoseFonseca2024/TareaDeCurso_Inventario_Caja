using BosquejoProyecto1.Class;
using BosquejoProyecto1.DTO_s.Producto;
using System.Net.Http.Json;

namespace BosquejoProyecto1.Forms.FormsInvetario
{
    public partial class FormRegistroCompra : Form
    {
        private readonly FormService _formService = new FormService();
        private readonly ProductoService _productoService = new ProductoService();
        private readonly CajaService cajaService = new CajaService();
        private readonly CompraService _compraService;
        private readonly string urlProductos = "https://localhost:7064/api/Productoes";
        private readonly string urlCompras = "https://localhost:7064/api/Compras";
        private readonly string urlcaja = "https://localhost:7064/api/Cajas";
        private readonly HttpClient client = new HttpClient();

        public FormRegistroCompra()
        {
            InitializeComponent();
            _formService.CambiodeColor(lblExit);
            _formService.CerrarConValidación(lblExit, this);
            _formService.CargarParametrosProductos(dgvProductos,cmbExistencia, lblID, txtID, txtNombre, txtCosto, txtPrecio, numUnidades);
            _formService.CargarParametrosCompra(dgvCompra, txtNombre, txtCosto, txtPrecio, numUnidades);
            _formService.BloquearTeclas(txtID);
            _formService.BloquearTeclas(txtCosto);
            _formService.BloquearTeclas(txtPrecio);

            _productoService.CargarProducto(dgvProductos, urlProductos, client);
            _compraService = new CompraService(_productoService);
            cmbExistencia.Items.Add("Nuevo");
            cmbExistencia.Items.Add("Registrado");
        }

        private void limpiarCampos ()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtCosto.Clear();
            txtPrecio.Clear();
            numUnidades.Value = 0;
            dgvProductos.ClearSelection();
        }

        private void Visibilidadparametro(ComboBox cmb, Label lbl, TextBox txt)
        {
            if (cmb.SelectedItem?.ToString() == "Registrado")
            {
                txt.Visible = true;
                lbl.Visible = true;
            }
            else
            {
                txt.Visible = false;
                lbl.Visible = false;
            }
        }

        private void cmbExistencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visibilidadparametro(cmbExistencia, lblID, txtID);
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            await _compraService.AgregarProductoaCompra(
                cmbExistencia,txtID,txtNombre,txtCosto,txtPrecio,numUnidades,dgvCompra,lblTotal
            );
            limpiarCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            _compraService.ActualizarProductoEnFactura(
                txtNombre,
                txtCosto,
                numUnidades,
                dgvCompra,
                lblTotal
            );
            limpiarCampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _compraService.EliminarProductoDeFactura(dgvCompra, lblTotal);
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            decimal saldocaja = await cajaService.CargarSaldo(client, urlcaja);

            await _compraService.ConfirmarCompraAsync(
                dgvCompra,
                lblTotal,
                client,
                urlCompras,
                urlProductos,
                saldocaja
            );

            // Refrescar el dgvProductos después de confirmar la compra
            var productos = await client.GetFromJsonAsync<List<ProductoREAD>>(urlProductos);
            dgvProductos.DataSource = productos;
        }
    }
}
