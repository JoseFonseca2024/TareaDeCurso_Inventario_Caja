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

namespace BosquejoProyecto1.Forms.FormsInvetario
{
    public partial class FormInventario : Form
    {
        private readonly FormService _formService = new FormService();
        public FormInventario()
        {
            InitializeComponent();
            _formService.CerrarSinValidar(lblExit, this);
            _formService.CambiodeColor(lblExit);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new FormRegistroCompra();
            form.ShowDialog();
        }
    }
}
