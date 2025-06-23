

using BosquejoProyecto1.Class;

namespace BosquejoProyecto1.Forms.FormsCaja
{
    public partial class FormCerrarCaja : Form
    {
        private readonly FormService _formService = new FormService();
        public readonly string url = "https://localhost:7064/api/Cajas";
        private readonly CajaService _cajaService = new CajaService();
        HttpClient cliente = new HttpClient();

        private decimal totalEnCajaFisica = 0;
        private decimal saldoRegistro = 0;
        private decimal diferencia = 0;

        public FormCerrarCaja()
        {
            InitializeComponent();
            _formService.CerrarConValidación(lblSalir, this);
            _formService.CambiodeColor(lblSalir);

        }

        private async void FormCerrarCaja_Load(object sender, EventArgs e)
        {
            saldoRegistro = await _cajaService.CargarSaldo( cliente, url);
            lblSaldosegunRegistro.Text = $"Saldo según registro {saldoRegistro:N2}";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            TextBox[] txt = { txt1cor, txt5cor, txt10cor, txt20cor, txt50cor, txt100cor, txt200cor, txt500cor, txt1000cor };

            if (_cajaService.ValidarCampos(txt))
            {
                totalEnCajaFisica = _cajaService.SumarDenominaciones(txt);
                diferencia = saldoRegistro - totalEnCajaFisica;
                lblTotalArqueo.Text = $"Total según Arqueo: {totalEnCajaFisica:N2}";
                lblDiferencia.BackColor = Color.Red;
                lblDiferencia.Text = $"Diferencia: {diferencia:N2}";
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (diferencia == 0)
            {
                DialogResult resp = MessageBox.Show("Esta seguro que quiere cerrar caja?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    await _cajaService.CerrarCaja(this,url, cliente);
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("La diferencia debe ser cero para cerrar la caja.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

    }
}
