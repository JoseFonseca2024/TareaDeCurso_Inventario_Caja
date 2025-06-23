using BosquejoProyecto1.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BosquejoProyecto1.Forms
{
    public partial class FormVerRegistros : Form
    {
        private readonly FormService _formService = new FormService();
        private readonly CajaService _cajaService = new CajaService();
        public readonly string url = "https://localhost:7064/api/MovimientoCajas";
        HttpClient cliente = new HttpClient();

        public FormVerRegistros()
        {
            InitializeComponent();
            _formService.CambiodeColor(lblExit);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void FormVerRegistros_Load(object sender, EventArgs e)
        {
            var ingresos = await _cajaService.ObtenerIngresos(cliente, url,lblContadorIngresos, lblMontoIngresoso);
            dgvIngresos.DataSource = ingresos;

            var egresos = await _cajaService.ObtenerEgresos(cliente, url, lblContadorEgresos, lblEgresosMonto);
            dgvEgresos.DataSource = egresos;
        }

    }
}
