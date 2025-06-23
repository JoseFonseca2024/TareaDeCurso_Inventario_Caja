using Azure;
using BosquejoProyecto1.Class;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace BosquejoProyecto1.Forms.FormsFacturación
{
    public partial class FormsPago : Form
    {
        private readonly FormService _formService = new FormService();
        private readonly decimal _totalFactura;

        public decimal MontoPagado { get; private set; }

        public FormsPago(decimal totalFactura)
        {
            InitializeComponent();
            _formService.CambiodeColor(lblExit);
            _formService.CerrarConValidación(lblExit, this);
            _formService.RegistroDenominación(btn100, txtPago);
            _formService.RegistroDenominación(btn200, txtPago);
            _formService.RegistroDenominación(btn500, txtPago);
            _formService.RegistroDenominación(btn1000, txtPago);
            _formService.BloquearTeclas(txtPago);

            _totalFactura = totalFactura;
        }


        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPago.Text))
            {
                MessageBox.Show("Campo vacio. Entrada no valida", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (Convert.ToDecimal(txtPago.Text) < _totalFactura)
            {
                MessageBox.Show("El monto ingresado es menor que el total a pagar.", "Pago insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MontoPagado = Convert.ToDecimal(txtPago.Text);


            var formDetalle = new FormDetallePago(_totalFactura, MontoPagado);
            formDetalle.ShowDialog();
            this.Close();
        }
    }
}
