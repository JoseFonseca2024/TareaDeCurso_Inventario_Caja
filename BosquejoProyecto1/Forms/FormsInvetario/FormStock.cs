using BosquejoProyecto1.Class;
using BosquejoProyecto1.DTO_s.Producto;

namespace BosquejoProyecto1.Forms.FormsInvetario
{
    public partial class FormStock : Form
    {
        private readonly ProductoService _productoService = new ProductoService();
        private readonly string url = "https://localhost:7064/api/Productoes";
        HttpClient client = new HttpClient();
        private ProductoService productoService = new ProductoService();
        private FormService formService = new FormService();

        public event Action<ProductoREAD> ProductoSeleccionado;

        public FormStock()
        {
            InitializeComponent();
            _productoService.CargarProducto(dgvStock, url, client);
            formService.CerrarSinValidar(lblExit, this);

            dgvStock.CellDoubleClick += dgvStock_CellDoubleClick;
        }

        private void dgvStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EnviarProductoSeleccionado();
        }

        private void EnviarProductoSeleccionado()
        {
            if (dgvStock.CurrentRow?.DataBoundItem is ProductoREAD producto)
            {
                ProductoSeleccionado?.Invoke(producto); // Lanza el evento
                this.Close();
            }
        }

        private async void btnBucarNombre_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto a buscar", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            await _productoService.BuscarProductoporNombre(txtNombre.Text, dgvStock, client, url);
        }

        private async void btnBuscarporID_Click(object sender, EventArgs e)
        {
            await _productoService.BuscarProductoporID(numID, dgvStock, client, url);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            EnviarProductoSeleccionado();
        }


    }
}
