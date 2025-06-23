using BosquejoProyecto1.DTO_s;
using BosquejoProyecto1.Class;
using BosquejoProyecto1.Forms.FormsCaja;
using System.Text.Json;
using System.Net.Http.Json;

namespace BosquejoProyecto1.Forms
{
    public partial class FormCaja : Form
    {
        private readonly FormService _formService = new FormService();
        private readonly CajaService _cajaService = new CajaService();
        public readonly string url = "https://localhost:7064/api/Cajas";
        HttpClient cliente = new HttpClient();
        private decimal saldoEnCaja = 0;

        public FormCaja()
        {
            InitializeComponent();
            _formService.CambiodeColor(lblExit);
        }

        private async void FormCaja_Load(object sender, EventArgs e)
        {
            saldoEnCaja = await _cajaService.CargarSaldo(cliente, url);

            if (saldoEnCaja == 0)
            {
                txtSaldo.Text = "C$ -";
            }
            else
            {
                txtSaldo.Text = $"C$ {saldoEnCaja.ToString()}";
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnVerIngresos_Click(object sender, EventArgs e)
        {
            bool existeCaja = await _cajaService.ExistenciadeCaja(cliente, url);

            if (existeCaja)
            {
                var form = new FormVerRegistros();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay registros de caja aún. Inicialice una primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInicializar_Click(object sender, EventArgs e)
        {
            var form = new FormInicializarSaldo();
            form.ShowDialog();
        }

        private async void btnCierre_Click(object sender, EventArgs e)
        {
            saldoEnCaja = await _cajaService.CargarSaldo(cliente, url);

            if (saldoEnCaja != 0)
            {
                var form = new FormCerrarCaja();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay caja activa por cerrar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }


    }
}
