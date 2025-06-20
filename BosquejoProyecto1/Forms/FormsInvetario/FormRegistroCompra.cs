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
    public partial class FormRegistroCompra : Form
    {
        private readonly FormService _formService = new FormService();
        public FormRegistroCompra()
        {
            InitializeComponent();
            _formService.CambiodeColor(lblExit);
            _formService.CerrarConValidación(lblExit, this);

            cmbExistencia.Items.Add("Nuevo");
            cmbExistencia.Items.Add("Registrado");
        }

        private void Visibilidadparametro(ComboBox cmb, Label lbl, TextBox txt)
        {
            if (cmb.SelectedItem?.ToString() == "Registrado")
            {
                txt.Visible = true;
                lbl.Visible = true;
            }
            else
            {
                txt.Visible = false;
                lbl.Visible = false;
            }
        }

        private void cmbExistencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visibilidadparametro(cmbExistencia, lblID, txtID);
        }
    }
}
