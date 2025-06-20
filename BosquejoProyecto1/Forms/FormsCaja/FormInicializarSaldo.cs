

using BosquejoProyecto1.Class;

namespace BosquejoProyecto1.Forms.FormsCaja
{
    public partial class FormInicializarSaldo : Form
    {
        private readonly FormService _formService = new FormService();
        public FormInicializarSaldo()
        {
            InitializeComponent();
            _formService.CerrarConValidación(lblExit, this);
            _formService.CambiodeColor(lblExit);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label2.Visible = true;
                label2.Text = "Ingrese un valor al saldo";
            }
            else
            {
                this.Close();
            }
        }

    }
}
