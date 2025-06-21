namespace BosquejoProyecto1.Forms.FormsInvetario
{
    partial class FormInventario
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
            panel2 = new Panel();
            lblExit = new Label();
            btnStock = new Button();
            pictureBox1 = new PictureBox();
            btnInicializar = new Button();
            btnVerIngresos = new Button();
            txtSaldo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            button1 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(lblExit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(686, 35);
            panel2.TabIndex = 8;
            // 
            // lblExit
            // 
            lblExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblExit.AutoSize = true;
            lblExit.BackColor = Color.Transparent;
            lblExit.Cursor = Cursors.Hand;
            lblExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.ForeColor = SystemColors.Control;
            lblExit.Location = new Point(661, 7);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(21, 20);
            lblExit.TabIndex = 1;
            lblExit.Text = "X";
            // 
            // btnStock
            // 
            btnStock.Location = new Point(187, 165);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(68, 30);
            btnStock.TabIndex = 20;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.inventario;
            pictureBox1.Location = new Point(508, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnInicializar
            // 
            btnInicializar.Location = new Point(12, 166);
            btnInicializar.Name = "btnInicializar";
            btnInicializar.Size = new Size(169, 30);
            btnInicializar.TabIndex = 17;
            btnInicializar.Text = "Inicializar Saldo de inventario";
            btnInicializar.UseVisualStyleBackColor = true;
            btnInicializar.Click += btnInicializar_Click;
            // 
            // btnVerIngresos
            // 
            btnVerIngresos.Location = new Point(389, 166);
            btnVerIngresos.Name = "btnVerIngresos";
            btnVerIngresos.Size = new Size(102, 30);
            btnVerIngresos.TabIndex = 18;
            btnVerIngresos.Text = "Ver Registros ";
            btnVerIngresos.UseVisualStyleBackColor = true;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(209, 51);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.ReadOnly = true;
            txtSaldo.Size = new Size(102, 23);
            txtSaldo.TabIndex = 16;
            txtSaldo.Text = "C$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(17, 128);
            label3.Name = "label3";
            label3.Size = new Size(192, 23);
            label3.TabIndex = 13;
            label3.Text = "Egresos Registrados:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(17, 87);
            label2.Name = "label2";
            label2.Size = new Size(200, 23);
            label2.TabIndex = 14;
            label2.Text = "Ingresos Registrados:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(17, 51);
            label4.Name = "label4";
            label4.Size = new Size(186, 23);
            label4.TabIndex = 15;
            label4.Text = "Valor de inventario:";
            // 
            // button1
            // 
            button1.Location = new Point(261, 165);
            button1.Name = "button1";
            button1.Size = new Size(122, 30);
            button1.TabIndex = 20;
            button1.Text = "Rellenar inventario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(686, 214);
            Controls.Add(button1);
            Controls.Add(btnStock);
            Controls.Add(pictureBox1);
            Controls.Add(btnInicializar);
            Controls.Add(btnVerIngresos);
            Controls.Add(txtSaldo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInventario";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label lblExit;
        private Button btnStock;
        private PictureBox pictureBox1;
        private Button btnInicializar;
        private Button btnVerIngresos;
        private TextBox txtSaldo;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button button1;
    }
}