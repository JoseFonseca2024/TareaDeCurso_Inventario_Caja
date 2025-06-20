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
        public FormVerRegistros()
        {
            InitializeComponent();
            _formService.CambiodeColor(lblExit);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
