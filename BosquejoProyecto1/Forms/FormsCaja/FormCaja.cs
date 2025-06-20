using BosquejoProyecto1.Class;
using BosquejoProyecto1.Forms.FormsCaja;

namespace BosquejoProyecto1.Forms
{
    public partial class FormCaja : Form
    {
        private readonly FormService _formService = new FormService();
        public FormCaja()
        {
            InitializeComponent();
            _formService.CambiodeColor(lblExit);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerIngresos_Click(object sender, EventArgs e)
        {
            var form = new FormVerRegistros();
            form.ShowDialog();
        }

        private void btnInicializar_Click(object sender, EventArgs e)
        {
            var form = new FormInicializarSaldo();
            form.ShowDialog();
        }

        private void btnCierre_Click(object sender, EventArgs e)
        {
            var form = new FormCerrarCaja();
            form.ShowDialog();
        }


    }
}
