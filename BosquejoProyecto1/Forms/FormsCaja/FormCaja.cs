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
        public readonly string url = "https://localhost:7064/api/Cajas";
        HttpClient cliente = new HttpClient();

        public FormCaja()
        {
            InitializeComponent();
            _formService.CambiodeColor(lblExit);
            CargarSaldo(txtSaldo);
        }

        private async void CargarSaldo(TextBox txt)
        {
            try
            {
                var cajas = await cliente.GetFromJsonAsync<List<CajaDTO>>(url);
                var cajaAbierta = cajas?.FirstOrDefault(); 
                if (cajaAbierta != null)
                    txt.Text = $"C$ {cajaAbierta.Saldo}";
                else
                    txt.Text = "C$ -";
            }
            catch
            {
                txt.Text = "C$ -";
            }
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
