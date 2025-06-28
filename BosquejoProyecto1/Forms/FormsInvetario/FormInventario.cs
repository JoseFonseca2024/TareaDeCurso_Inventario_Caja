using BosquejoProyecto1.Class;

namespace BosquejoProyecto1.Forms.FormsInvetario
{
    public partial class FormInventario : Form
    {
        private readonly FormService _formService = new FormService();
        private readonly ProductoService _productoService = new ProductoService();
        private readonly CajaService _cajaService = new CajaService();
        public readonly string urlCaja = "https://localhost:7064/api/Cajas";
        private readonly string url = "https://localhost:7064/api/Productoes";
        HttpClient client = new HttpClient();
        public FormInventario()
        {
            InitializeComponent();
            _formService.CerrarSinValidar(lblExit, this);
            _formService.CambiodeColor(lblExit);
        }

        private async void btnRellenarInventario_Click(object sender, EventArgs e)
        {
            decimal saldocaja = await _cajaService.CargarSaldo(client, urlCaja);
            bool existencia = await _productoService.ExistenciadeInventario(client, url);
            if (existencia == true && saldocaja != 0)
            {
                var form = new FormRegistroCompra();
                form.ShowDialog();
            }
            else if (saldocaja == 0)
            {
                MessageBox.Show("Incialice el saldo de caja primeramente", "Caja no inicializada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Incialice el slado en inventario primeramente", "Invetario no inicializado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private async void btnInicializar_Click(object sender, EventArgs e)
        {
            bool existencia = await _productoService.ExistenciadeInventario(client, url);
            if (existencia != true)
            {
                var form = new FormInicializacionInventario();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("El inventario ya ha sido incializado completamente", "Inicialización una vez", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private async void btnStock_Click(object sender, EventArgs e)
        {
            bool existencia = await _productoService.ExistenciadeInventario(client, url);
            if (existencia == true)
            {
                var form = new FormStock();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay inventario por mostrar, porfavor inicialice", "Invetario no inicializado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private async void FormInventario_Load(object sender, EventArgs e)
        {
            decimal valorinventario = await _productoService.ObtenerValorInventario(client, url);
            if (valorinventario != 0)
            {
                txtSaldo.Text = $"C$ {valorinventario}";
            }
            else
            {
                txtSaldo.Text = $"C$ -";
            }
        }
    }
}
