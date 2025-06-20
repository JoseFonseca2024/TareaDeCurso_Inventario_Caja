namespace BosquejoProyecto1.Forms.FormsInvetario
{
    partial class FormRegistroCompra
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            numUnidades = new NumericUpDown();
            txtPrecio = new TextBox();
            txtCosto = new TextBox();
            txtID = new TextBox();
            txtNombre = new TextBox();
            cmbExistencia = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            lblID = new Label();
            label2 = new Label();
            dgvProductos = new DataGridView();
            label7 = new Label();
            dgvCompra = new DataGridView();
            label8 = new Label();
            button4 = new Button();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUnidades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompra).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(lblExit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 38);
            panel2.TabIndex = 10;
            // 
            // lblExit
            // 
            lblExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblExit.AutoSize = true;
            lblExit.BackColor = Color.Transparent;
            lblExit.Cursor = Cursors.Hand;
            lblExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.ForeColor = SystemColors.Control;
            lblExit.Location = new Point(867, 9);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(21, 20);
            lblExit.TabIndex = 1;
            lblExit.Text = "X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(432, 53);
            label1.Name = "label1";
            label1.Size = new Size(339, 24);
            label1.TabIndex = 11;
            label1.Text = "Productos registrados previamente:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numUnidades);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtCosto);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(cmbExistencia);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblID);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(25, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 306);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de productos";
            // 
            // numUnidades
            // 
            numUnidades.Location = new Point(101, 189);
            numUnidades.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUnidades.Name = "numUnidades";
            numUnidades.Size = new Size(120, 27);
            numUnidades.TabIndex = 17;
            numUnidades.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(101, 143);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 27);
            txtPrecio.TabIndex = 16;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(101, 106);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(100, 27);
            txtCosto.TabIndex = 16;
            // 
            // txtID
            // 
            txtID.Location = new Point(239, 67);
            txtID.Name = "txtID";
            txtID.Size = new Size(70, 27);
            txtID.TabIndex = 16;
            txtID.Visible = false;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(101, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 27);
            txtNombre.TabIndex = 16;
            // 
            // cmbExistencia
            // 
            cmbExistencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbExistencia.FormattingEnabled = true;
            cmbExistencia.Location = new Point(101, 28);
            cmbExistencia.Name = "cmbExistencia";
            cmbExistencia.Size = new Size(185, 27);
            cmbExistencia.TabIndex = 15;
            cmbExistencia.SelectedIndexChanged += cmbExistencia_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(247, 236);
            button3.Name = "button3";
            button3.Size = new Size(86, 30);
            button3.TabIndex = 14;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(142, 236);
            button2.Name = "button2";
            button2.Size = new Size(86, 30);
            button2.TabIndex = 14;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(28, 236);
            button1.Name = "button1";
            button1.Size = new Size(86, 30);
            button1.TabIndex = 14;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(15, 191);
            label5.Name = "label5";
            label5.Size = new Size(79, 19);
            label5.TabIndex = 13;
            label5.Text = "Unidades:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(16, 151);
            label4.Name = "label4";
            label4.Size = new Size(55, 19);
            label4.TabIndex = 13;
            label4.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(15, 114);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 13;
            label3.Text = "Costo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(15, 32);
            label6.Name = "label6";
            label6.Size = new Size(79, 19);
            label6.TabIndex = 13;
            label6.Text = "Existencia:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.Transparent;
            lblID.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.ForeColor = SystemColors.ActiveCaptionText;
            lblID.Location = new Point(207, 70);
            lblID.Name = "lblID";
            lblID.Size = new Size(26, 19);
            lblID.TabIndex = 13;
            lblID.Text = "Id:";
            lblID.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(15, 70);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 13;
            label2.Text = "Nombre:";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(436, 84);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(452, 275);
            dgvProductos.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(25, 372);
            label7.Name = "label7";
            label7.Size = new Size(182, 24);
            label7.TabIndex = 11;
            label7.Text = "Detalle de ingreso:";
            // 
            // dgvCompra
            // 
            dgvCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompra.Location = new Point(25, 399);
            dgvCompra.Name = "dgvCompra";
            dgvCompra.Size = new Size(725, 289);
            dgvCompra.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(756, 664);
            label8.Name = "label8";
            label8.Size = new Size(61, 24);
            label8.TabIndex = 11;
            label8.Text = "Total:";
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(756, 399);
            button4.Name = "button4";
            button4.Size = new Size(132, 30);
            button4.TabIndex = 14;
            button4.Text = "Aceptar Compra";
            button4.UseVisualStyleBackColor = true;
            // 
            // FormRegistroCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(dgvCompra);
            Controls.Add(dgvProductos);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(button4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistroCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInventario";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUnidades).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label lblExit;
        private Label label1;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private DataGridView dgvProductos;
        private NumericUpDown numUnidades;
        private TextBox txtPrecio;
        private TextBox txtCosto;
        private TextBox txtNombre;
        private ComboBox cmbExistencia;
        private Label label6;
        private Label label7;
        private DataGridView dgvCompra;
        private Label label8;
        private Button button4;
        private TextBox txtID;
        private Label lblID;
    }
}