using BosquejoProyecto1.Class;
using BosquejoProyecto1.Forms.FormsCaja;

namespace BosquejoProyecto1.Forms
{
    public partial class FormCaja : Form
    {
        private readonly FormService _formService = new FormService();
        private readonly CajaService _cajaService = new CajaService();
        public readonly string urlCaja = "https://localhost:7064/api/Cajas";
        public readonly string urlMovimientoCaja = "https://localhost:7064/api/MovimientoCajas";

        HttpClient cliente = new HttpClient();
        private decimal saldoEnCaja = 0;

        public FormCaja()
        {
            InitializeComponent();
            _formService.CambiodeColor(lblExit);
        }

        private async void FormCaja_Load(object sender, EventArgs e)
        {
            await _cajaService.ActualizarSaldoEnTextBox(cliente, urlCaja, txtSaldo);

            await _cajaService.ContarIngresos(cliente, urlMovimientoCaja, label2);
            await _cajaService.ContarEgresos(cliente, urlMovimientoCaja, label3);

            timerActualizarSaldo.Interval = 5000;
            timerActualizarSaldo.Tick += TimerActualizarSaldo_Tick;
            timerActualizarSaldo.Start();
        }

        private async void TimerActualizarSaldo_Tick(object sender, EventArgs e)
        {
            await _cajaService.ActualizarSaldoEnTextBox(cliente, urlCaja, txtSaldo);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnVerIngresos_Click(object sender, EventArgs e)
        {
            bool existeCaja = await _cajaService.ExistenciadeCaja(cliente, urlCaja);

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
            saldoEnCaja = await _cajaService.CargarSaldo(cliente, urlCaja);

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
