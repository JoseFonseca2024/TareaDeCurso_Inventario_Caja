using BosquejoProyecto1.Class;
using BosquejoProyecto1.Forms;
using BosquejoProyecto1.Forms.FormsInvetario;


namespace BosquejoProyecto1
{
    public partial class MainForm : Form
    {
        private readonly FormService formService = new FormService();

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

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            var form = new FormFacturación();
            form.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            var form = new FormInventario();
            form.ShowDialog();
        }
    }
}
