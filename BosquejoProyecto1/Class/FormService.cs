using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BosquejoProyecto1.Class
{
    public class FormService
    {
        private decimal totalAcumulado = 0;
        public void CambiodeColor (Label label)
        {
            label.MouseEnter += (s, e) =>
            {
                label.ForeColor = Color.Red;
            };

            label.MouseLeave += (s, e) =>
            {
                label.ForeColor = SystemColors.Control;
            };
        }

        public void Minimizar(Label label, Form form) 
        {
            label.Click += (s, e) =>
            {
                form.WindowState = FormWindowState.Minimized;
            };

        }


        public void CerrarConValidación(Label label, Form form1) 
        {
            label.Click += (s, e) =>
            {
                DialogResult reps = MessageBox.Show("Esta seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reps == DialogResult.Yes)
                {
                    form1.Close();
                }
                else
                {
                    return;
                }
            };
        }

        public void RegistroDenominación(Button btn, TextBox txt)
        {
            btn.Click += (s, e) =>
            {
                decimal dinero = Convert.ToDecimal(btn.Text);
                totalAcumulado += dinero;
                txt.Text = totalAcumulado.ToString("N2");
            };
        }

        public void CerrarSinValidar(Label lbl, Form form) 
        {
            lbl.Click += (s, e) =>
            {
                    form.Close();
            };

        }

    }
}
