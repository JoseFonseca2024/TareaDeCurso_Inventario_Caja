namespace BosquejoProyecto1.Forms
{
    partial class FormFacturación
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
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            btnBucarNombre = new Button();
            btnBuscarporID = new Button();
            numericUpDown1 = new NumericUpDown();
            txtPrecio = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnQuitar = new Button();
            btnPagar = new Button();
            label5 = new Label();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(lblExit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(890, 38);
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
            lblExit.Location = new Point(857, 9);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(21, 20);
            lblExit.TabIndex = 1;
            lblExit.Text = "X";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnBucarNombre);
            groupBox1.Controls.Add(btnBuscarporID);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft PhagsPa", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(12, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(857, 144);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle Factura";
            // 
            // btnAgregar
            // 
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Location = new Point(523, 36);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(161, 28);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar a Factura";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnBucarNombre
            // 
            btnBucarNombre.ForeColor = SystemColors.ActiveCaptionText;
            btnBucarNombre.Location = new Point(346, 36);
            btnBucarNombre.Name = "btnBucarNombre";
            btnBucarNombre.Size = new Size(161, 28);
            btnBucarNombre.TabIndex = 4;
            btnBucarNombre.Text = "Buscar por Nombre";
            btnBucarNombre.UseVisualStyleBackColor = true;
            // 
            // btnBuscarporID
            // 
            btnBuscarporID.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscarporID.Location = new Point(164, 36);
            btnBuscarporID.Name = "btnBuscarporID";
            btnBuscarporID.Size = new Size(161, 28);
            btnBuscarporID.TabIndex = 4;
            btnBuscarporID.Text = "Buscar por ID";
            btnBuscarporID.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(747, 106);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(89, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(517, 105);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 27);
            txtPrecio.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(315, 105);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 28);
            comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(108, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 28);
            comboBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(655, 108);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 0;
            label4.Text = "Cantidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(448, 108);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 0;
            label3.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(242, 108);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(6, 105);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Codigo ID:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 232);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(684, 227);
            dataGridView1.TabIndex = 10;
            // 
            // btnQuitar
            // 
            btnQuitar.ForeColor = SystemColors.ActiveCaptionText;
            btnQuitar.Location = new Point(708, 232);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(161, 28);
            btnQuitar.TabIndex = 4;
            btnQuitar.Text = "Quitar de Factura";
            btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            btnPagar.ForeColor = SystemColors.ActiveCaptionText;
            btnPagar.Location = new Point(708, 266);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(161, 28);
            btnPagar.TabIndex = 4;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(708, 437);
            label5.Name = "label5";
            label5.Size = new Size(74, 22);
            label5.TabIndex = 11;
            label5.Text = "TOTAL: ";
            // 
            // FormFacturación
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(890, 471);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(btnPagar);
            Controls.Add(btnQuitar);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFacturación";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormFacturación";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;

        private Label lblExit;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBucarNombre;
        private Button btnBuscarporID;
        private NumericUpDown numericUpDown1;
        private TextBox txtPrecio;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private Button btnQuitar;
        private Button btnPagar;
        private Label label5;
    }
}