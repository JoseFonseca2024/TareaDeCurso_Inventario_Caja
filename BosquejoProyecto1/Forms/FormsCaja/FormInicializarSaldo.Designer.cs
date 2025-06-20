namespace BosquejoProyecto1.Forms.FormsCaja
{
    partial class FormInicializarSaldo
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
            lblEgresos = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            btnAceptar = new Button();
            panel2.SuspendLayout();
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
            lblExit.Location = new Point(505, 9);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(21, 20);
            lblExit.TabIndex = 1;
            lblExit.Text = "X";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(lblExit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(538, 35);
            panel2.TabIndex = 15;
            // 
            // lblEgresos
            // 
            lblEgresos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblEgresos.AutoSize = true;
            lblEgresos.BackColor = Color.Transparent;
            lblEgresos.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEgresos.ForeColor = SystemColors.ActiveCaptionText;
            lblEgresos.Location = new Point(137, 46);
            lblEgresos.Name = "lblEgresos";
            lblEgresos.Size = new Size(270, 31);
            lblEgresos.TabIndex = 16;
            lblEgresos.Text = "Inicialización de Saldo";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 17;
            label1.Text = "Saldo a iniciar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(137, 122);
            label2.Name = "label2";
            label2.Size = new Size(281, 15);
            label2.TabIndex = 18;
            label2.Text = "El dato ingresado tiene que ser mayor a 0*";
            label2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(376, 23);
            textBox1.TabIndex = 19;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(224, 153);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(98, 30);
            btnAceptar.TabIndex = 20;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FormInicializarSaldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(538, 195);
            Controls.Add(btnAceptar);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblEgresos);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInicializarSaldo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInicializarSaldo";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExit;
        private Panel panel2;
        private Label lblEgresos;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button btnAceptar;
    }
}