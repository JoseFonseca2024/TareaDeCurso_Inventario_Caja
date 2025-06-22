namespace BosquejoProyecto1.Forms
{
    partial class FormCaja
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
            lblExit = new Label();
            panel2 = new Panel();
            label1 = new Label();
            txtSaldo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnVerIngresos = new Button();
            btnInicializar = new Button();
            pictureBox1 = new PictureBox();
            btnCierre = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblExit
            // 
            lblExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblExit.AutoSize = true;
            lblExit.BackColor = Color.Transparent;
            lblExit.Cursor = Cursors.Hand;
            lblExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.ForeColor = SystemColors.Control;
            lblExit.Location = new Point(527, 7);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(21, 20);
            lblExit.TabIndex = 1;
            lblExit.Text = "X";
            lblExit.Click += lblExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(lblExit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(552, 35);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(22, 52);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 7;
            label1.Text = "Saldo en Caja:";
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(162, 52);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.ReadOnly = true;
            txtSaldo.Size = new Size(102, 23);
            txtSaldo.TabIndex = 9;
            txtSaldo.Text = "C$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(22, 88);
            label2.Name = "label2";
            label2.Size = new Size(200, 23);
            label2.TabIndex = 7;
            label2.Text = "Ingresos Registrados:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(22, 129);
            label3.Name = "label3";
            label3.Size = new Size(192, 23);
            label3.TabIndex = 7;
            label3.Text = "Egresos Registrados:";
            // 
            // btnVerIngresos
            // 
            btnVerIngresos.Location = new Point(22, 166);
            btnVerIngresos.Name = "btnVerIngresos";
            btnVerIngresos.Size = new Size(102, 30);
            btnVerIngresos.TabIndex = 10;
            btnVerIngresos.Text = "Ver Registros ";
            btnVerIngresos.UseVisualStyleBackColor = true;
            btnVerIngresos.Click += btnVerIngresos_Click;
            // 
            // btnInicializar
            // 
            btnInicializar.Location = new Point(130, 166);
            btnInicializar.Name = "btnInicializar";
            btnInicializar.Size = new Size(143, 30);
            btnInicializar.TabIndex = 10;
            btnInicializar.Text = "Inicializar Saldo de Caja";
            btnInicializar.UseVisualStyleBackColor = true;
            btnInicializar.Click += btnInicializar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cajero_automatico;
            pictureBox1.Location = new Point(380, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnCierre
            // 
            btnCierre.Location = new Point(279, 166);
            btnCierre.Name = "btnCierre";
            btnCierre.Size = new Size(86, 30);
            btnCierre.TabIndex = 12;
            btnCierre.Text = "Cerrar Caja";
            btnCierre.UseVisualStyleBackColor = true;
            btnCierre.Click += btnCierre_Click;
            // 
            // FormCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(552, 217);
            Controls.Add(btnCierre);
            Controls.Add(pictureBox1);
            Controls.Add(btnInicializar);
            Controls.Add(btnVerIngresos);
            Controls.Add(txtSaldo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCaja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormFacturación";
            Load += FormCaja_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblExit;
        private Panel panel2;
        private Label label1;
        private TextBox txtSaldo;
        private Label label2;
        private Label label3;
        private Button btnVerIngresos;
        private Button btnInicializar;
        private PictureBox pictureBox1;
        private Button btnCierre;
    }
}