using BosquejoProyecto1.Class;


namespace BosquejoProyecto1.Forms.FormsInvetario
{
    public partial class FormInicializacionInventario : Form
    {
        private readonly FormService formService = new FormService();
        private readonly ProductoService productoService = new ProductoService();
        private readonly string url = "https://localhost:7064/api/Productoes";
        HttpClient client = new HttpClient();
        public FormInicializacionInventario()
        {
            InitializeComponent();
            formService.CerrarConValidación(lblExit, this);
            formService.CambiodeColor(lblExit);
            formService.BloquearTeclas(txtCostoProducto);
            formService.BloquearTeclas(txtPrecio);
            productoService.CargarProducto(dgvRegistroProductos, url, client);
            formService.CargarParametrosCompra(dgvRegistroProductos, txtNombreProducto, txtCostoProducto, txtPrecio, numCantidad);
        }

        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtCostoProducto.Clear();
            txtPrecio.Clear();
            numCantidad.Value = 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            productoService.AgregarProducto(txtNombreProducto, txtCostoProducto, txtPrecio, numCantidad, dgvRegistroProductos, url, client);
            LimpiarCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            productoService.ActualizarProducto(dgvRegistroProductos, txtNombreProducto, txtCostoProducto, txtPrecio, numCantidad, url, client);
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            productoService.EliminarProducto(dgvRegistroProductos, txtNombreProducto, txtCostoProducto, txtPrecio, numCantidad, url, client);
            LimpiarCampos();
        }


    }
}
