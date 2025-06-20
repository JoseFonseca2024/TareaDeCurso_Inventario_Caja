namespace BosquejoProyecto1
{
    partial class FormInicioSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ptbUsuario = new PictureBox();
            lblExit = new Label();
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            txtContraseña = new TextBox();
            label3 = new Label();
            ptbVerContra = new PictureBox();
            lblMinimize = new Label();
            btnEntrar = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbVerContra).BeginInit();
            SuspendLayout();
            // 
            // ptbUsuario
            // 
            ptbUsuario.BackColor = Color.Transparent;
            ptbUsuario.Image = Properties.Resources.Imagen_de_WhatsApp_2025_06_19_a_las_19_14_01_d26969fe_removebg_preview;
            ptbUsuario.Location = new Point(111, 43);
            ptbUsuario.Name = "ptbUsuario";
            ptbUsuario.Size = new Size(183, 190);
            ptbUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            ptbUsuario.TabIndex = 0;
            ptbUsuario.TabStop = false;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.BackColor = Color.Transparent;
            lblExit.Cursor = Cursors.Hand;
            lblExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.ForeColor = SystemColors.Control;
            lblExit.Location = new Point(378, 9);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(21, 20);
            lblExit.TabIndex = 1;
            lblExit.Text = "X";
            lblExit.Click += lblExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(111, 21);
            label1.Name = "label1";
            label1.Size = new Size(196, 31);
            label1.TabIndex = 2;
            label1.Text = "INICIAR SESIÓN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(35, 216);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 3;
            label2.Text = "Usuario:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(35, 236);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(350, 23);
            txtUserName.TabIndex = 4;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(35, 292);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(350, 23);
            txtContraseña.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(35, 272);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 5;
            label3.Text = "Contraseña:";
            // 
            // ptbVerContra
            // 
            ptbVerContra.BackColor = Color.White;
            ptbVerContra.Cursor = Cursors.Hand;
            ptbVerContra.Image = Properties.Resources.ver;
            ptbVerContra.Location = new Point(361, 292);
            ptbVerContra.Name = "ptbVerContra";
            ptbVerContra.Size = new Size(24, 23);
            ptbVerContra.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbVerContra.TabIndex = 7;
            ptbVerContra.TabStop = false;
            ptbVerContra.Click += ptbVerContra_Click;
            // 
            // lblMinimize
            // 
            lblMinimize.AutoSize = true;
            lblMinimize.Cursor = Cursors.Hand;
            lblMinimize.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinimize.ForeColor = SystemColors.Control;
            lblMinimize.Location = new Point(357, 6);
            lblMinimize.Name = "lblMinimize";
            lblMinimize.Size = new Size(18, 20);
            lblMinimize.TabIndex = 1;
            lblMinimize.Text = "_";
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(173, 340);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 31);
            btnEntrar.TabIndex = 8;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // FormInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(411, 466);
            ControlBox = false;
            Controls.Add(btnEntrar);
            Controls.Add(ptbVerContra);
            Controls.Add(txtContraseña);
            Controls.Add(label3);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblMinimize);
            Controls.Add(lblExit);
            Controls.Add(ptbUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormIniciarCesion";
            ((System.ComponentModel.ISupportInitialize)ptbUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbVerContra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptbUsuario;
        private Label lblExit;
        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtContraseña;
        private Label label3;
        private PictureBox ptbVerContra;
        private Label lblMinimize;
        private Button btnEntrar;
    }
}