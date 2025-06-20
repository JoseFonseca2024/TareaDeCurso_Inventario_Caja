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

namespace BosquejoProyecto1.Forms.FormsFacturación
{
    public partial class FormDetallePago : Form
    {
        private readonly FormService _formService = new FormService();
        public FormDetallePago()
        {
            InitializeComponent();
            _formService.CambiodeColor(lblSalir);
            _formService.CerrarSinValidar(lblSalir, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
