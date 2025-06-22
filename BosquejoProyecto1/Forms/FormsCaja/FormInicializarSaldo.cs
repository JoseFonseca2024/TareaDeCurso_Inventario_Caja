using BosquejoProyecto1.Class;
using BosquejoProyecto1.DTO_s;
using System.Net.Http.Json;

namespace BosquejoProyecto1.Forms.FormsCaja
{
    public partial class FormInicializarSaldo : Form
    {
        private readonly FormService _formService = new FormService();
        private readonly CajaService _cajaService = new CajaService();
        public readonly string url = "https://localhost:7064/api/Cajas";
        HttpClient cliente = new HttpClient();

        public FormInicializarSaldo()
        {
            InitializeComponent();
            _formService.CerrarConValidación(lblExit, this);
            _formService.CambiodeColor(lblExit);
            _formService.BloquearTeclas(txtSaldo);
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            await _cajaService.InicializarSaldo(this,txtSaldo, label2, url, cliente);
        }
        
       
    }
}
