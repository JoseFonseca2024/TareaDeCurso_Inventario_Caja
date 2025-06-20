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

namespace BosquejoProyecto1
{
    public partial class FormInicioSesion : Form
    {
        private string usuario;
        private string contraseña;
        private readonly FormService formService = new FormService();


        public FormInicioSesion()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();

            usuario = "Alexa's_Bazzar2025";
            contraseña = "Mitienda2025";

            formService.CambiodeColor(lblExit);
            formService.CambiodeColor(lblMinimize);
            formService.Minimizar(lblMinimize, this);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void ptbVerContra_Click(object sender, EventArgs e)
        {
            if (txtContraseña.PasswordChar == '*') //Contraseña esta oculta
            {
                ptbVerContra.Image = Properties.Resources.ojo;
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                ptbVerContra.Image = Properties.Resources.ver;
                txtContraseña.PasswordChar = '*';
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContraseña.Text) || string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Rellene todos los campos", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtUserName.Text != usuario || txtContraseña.Text != contraseña)
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Verifique lo ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var MainForm = new MainForm(txtUserName.Text);
            MainForm.Show();
            this.Hide();

        }
    }
}
