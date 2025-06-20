using BosquejoProyecto1.Class;


namespace BosquejoProyecto1.Forms.FormsFacturación
{
    public partial class FormsPago : Form
    {
        private readonly FormService _formService = new FormService();
        public FormsPago()
        {
            InitializeComponent();
            _formService.CambiodeColor(lblExit);
            _formService.CerrarConValidación(lblExit, this);
            _formService.RegistroDenominación(btn100, txtPago);
            _formService.RegistroDenominación(btn200, txtPago);
            _formService.RegistroDenominación(btn500, txtPago);
            _formService.RegistroDenominación(btn1000, txtPago);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPago.Text))
            {
                MessageBox.Show("Campo vacio. Entrada no valida", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            this.Close();
            var form = new FormDetallePago();
            form.ShowDialog();
        }
    }
}
