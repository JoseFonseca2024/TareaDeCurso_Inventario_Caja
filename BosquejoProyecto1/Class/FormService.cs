namespace BosquejoProyecto1.Class
{
    public class FormService
    {
        private decimal totalAcumulado = 0;
        public void CambiodeColor(Label label)
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
        public void BloquearTeclas(TextBox txt)
        {
            txt.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true; // Bloquea cualquier otra tecla que no sea numero o punto decimal
                }

            };
        }

        public void CargarParametrosProductos(DataGridView dg, ComboBox cmb, Label id, TextBox txtid ,TextBox txt1, TextBox txt2, TextBox txt3, NumericUpDown num)
        {
            dg.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    cmb.SelectedItem = "Registrado";
                    id.Visible = true;
                    txtid.Visible = true;
                    DataGridViewRow fila = dg.Rows[e.RowIndex];
                    txtid.Text = fila.Cells["ProductoID"].Value.ToString();
                    txt1.Text = fila.Cells["NombreProducto"].Value.ToString();
                    txt2.Text = fila.Cells["CostoProducto"].Value?.ToString();
                    txt3.Text = fila.Cells["PrecioConIVA"].Value?.ToString();
                    num.Value = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                }
            };
        }

        public void CargarParametrosCompra(DataGridView dg, TextBox txt1, TextBox txt2, TextBox txt3, NumericUpDown num)
        {
            dg.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dg.Rows[e.RowIndex];
                    txt1.Text = fila.Cells["NombreProducto"].Value.ToString();
                    txt2.Text = fila.Cells["CostoUnitario"].Value?.ToString();
                    txt3.Text = fila.Cells["IVAUnitario"].Value?.ToString();
                    num.Value = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                }
            };
        }
    }
}
