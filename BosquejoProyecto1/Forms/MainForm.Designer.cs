namespace BosquejoProyecto1
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lblExit = new Label();
            lblMinimize = new Label();
            btnFacturar = new Button();
            panel1 = new Panel();
            btnCaja = new Button();
            btnSalir = new Button();
            btnInventario = new Button();
            lblHora = new Label();
            lblFecha = new Label();
            reloj = new System.Windows.Forms.Timer(components);
            lblUsuario = new Label();
            panel2 = new Panel();
            lblMax = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
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
            lblExit.Location = new Point(1181, 11);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(21, 20);
            lblExit.TabIndex = 1;
            lblExit.Text = "X";
            lblExit.Click += lblExit_Click;
            // 
            // lblMinimize
            // 
            lblMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMinimize.AutoSize = true;
            lblMinimize.Cursor = Cursors.Hand;
            lblMinimize.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinimize.ForeColor = SystemColors.Control;
            lblMinimize.Location = new Point(1134, 7);
            lblMinimize.Name = "lblMinimize";
            lblMinimize.Size = new Size(18, 20);
            lblMinimize.TabIndex = 1;
            lblMinimize.Text = "_";
            // 
            // btnFacturar
            // 
            btnFacturar.Image = (Image)resources.GetObject("btnFacturar.Image");
            btnFacturar.Location = new Point(12, 44);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(110, 46);
            btnFacturar.TabIndex = 2;
            btnFacturar.Text = "Facturar";
            btnFacturar.TextAlign = ContentAlignment.MiddleRight;
            btnFacturar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFacturar.UseVisualStyleBackColor = true;
            btnFacturar.Click += btnFacturar_Click;
            // 
            // panel1
            // 
            panel1.AccessibleRole = AccessibleRole.None;
            panel1.BackColor = Color.FromArgb(225, 225, 225);
            panel1.Controls.Add(btnCaja);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnInventario);
            panel1.Controls.Add(btnFacturar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 106);
            panel1.TabIndex = 3;
            // 
            // btnCaja
            // 
            btnCaja.Image = (Image)resources.GetObject("btnCaja.Image");
            btnCaja.Location = new Point(128, 44);
            btnCaja.Name = "btnCaja";
            btnCaja.Size = new Size(110, 46);
            btnCaja.TabIndex = 3;
            btnCaja.Text = "Caja";
            btnCaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCaja.UseVisualStyleBackColor = true;
            btnCaja.Click += btnCaja_Click;
            // 
            // btnSalir
            // 
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(360, 44);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 46);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnInventario
            // 
            btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
            btnInventario.Location = new Point(244, 44);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(110, 46);
            btnInventario.TabIndex = 3;
            btnInventario.Text = "Inventario";
            btnInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblHora.AutoSize = true;
            lblHora.BackColor = SystemColors.Control;
            lblHora.Font = new Font("Microsoft JhengHei", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = SystemColors.ActiveCaptionText;
            lblHora.Location = new Point(33, 439);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(147, 45);
            lblHora.TabIndex = 5;
            lblHora.Text = "lblHora";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFecha.AutoSize = true;
            lblFecha.BackColor = SystemColors.Control;
            lblFecha.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = SystemColors.ActiveCaptionText;
            lblFecha.Location = new Point(32, 486);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(111, 31);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "lblFecha";
            // 
            // reloj
            // 
            reloj.Tick += correReloj;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.ActiveCaptionText;
            lblUsuario.Location = new Point(33, 134);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(84, 23);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario:";
            // 
            // panel2
            // 
            panel2.AccessibleRole = AccessibleRole.None;
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(lblMax);
            panel2.Controls.Add(lblMinimize);
            panel2.Controls.Add(lblExit);
            panel2.Location = new Point(-14, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1240, 38);
            panel2.TabIndex = 7;
            // 
            // lblMax
            // 
            lblMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMax.AutoSize = true;
            lblMax.Cursor = Cursors.Hand;
            lblMax.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMax.ForeColor = SystemColors.Control;
            lblMax.Location = new Point(1155, 9);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(25, 20);
            lblMax.TabIndex = 2;
            lblMax.Text = "[]";
            lblMax.Click += lblMax_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Imagen_de_WhatsApp_2025_06_19_a_las_19_14_01_d26969fe_removebg_preview;
            pictureBox1.Location = new Point(779, 192);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(447, 428);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImage = Properties.Resources.istockphoto_1419799986_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 550);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(lblUsuario);
            Controls.Add(lblFecha);
            Controls.Add(lblHora);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExit;
        private Label lblMinimize;
        private Button btnFacturar;
        private Panel panel1;
        private Button btnInventario;
        private Label lblHora;
        private Label lblFecha;
        private System.Windows.Forms.Timer reloj;
        private Label lblUsuario;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnCaja;
        private Button btnSalir;
        private Label lblMax;
    }
}