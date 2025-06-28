using BosquejoProyecto1.Class;
using BosquejoProyecto1.DTO_s;
using BosquejoProyecto1.Forms;
using BosquejoProyecto1.Forms.FormsInvetario;
using System.Net.Http.Json;


namespace BosquejoProyecto1
{
    public partial class MainForm : Form
    {
        private readonly FormService formService = new FormService();
        public readonly string url = "https://localhost:7064/api/Cajas";
        HttpClient cliente = new HttpClient();
        private ProductoService productoService = new ProductoService();
        private readonly string urlProductos = "https://localhost:7064/api/Productoes";

        public MainForm(string usuario)
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToLongDateString();
            reloj.Start();
            lblUsuario.Text = $"Usuario: {usuario}";
            formService.CambiodeColor(lblExit);
            formService.CambiodeColor(lblMinimize);
            formService.CambiodeColor(lblMax);
            formService.Minimizar(lblMinimize, this);
        }


        private void lblMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void correReloj(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult reps = MessageBox.Show("Esta seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reps == DialogResult.Yes)
            {
                var FormInicio = new FormInicioSesion();
                FormInicio.Show();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            var form = new FormCaja();
            form.ShowDialog();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult reps = MessageBox.Show("Esta seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reps == DialogResult.Yes)
            {
                var form = new FormInicioSesion();
                form.Show();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private async void btnFacturar_Click(object sender, EventArgs e)
        {
            var cajas = await cliente.GetFromJsonAsync<List<CajaDTO>>(url);
            var caja = cajas?.FirstOrDefault();

            bool existencia = await productoService.ExistenciadeInventario(cliente, urlProductos);

            if (caja != null && caja.Saldo > 0 && existencia == true)
            {
                var form = new FormFacturación();
                form.ShowDialog();
            }
            else if (caja == null || caja.Saldo == 0)
            {
                MessageBox.Show("No hay caja abierta para facturar. Inicialice saldo en caja primeramente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (existencia == false)
            {
                MessageBox.Show("No hay inventario inicializado para facturar. Inicialice inventario primeramente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            var form = new FormInventario();
            form.ShowDialog();
        }
    }
}
