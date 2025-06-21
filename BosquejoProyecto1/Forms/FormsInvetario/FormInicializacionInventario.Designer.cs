namespace BosquejoProyecto1.Forms.FormsInvetario
{
    partial class FormInicializacionInventario
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
            groupBox1 = new GroupBox();
            dgvRegistroProductos = new DataGridView();
            btnRegistrar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            txtNombreProducto = new TextBox();
            txtCostoProducto = new TextBox();
            txtPrecio = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtCostoProducto);
            groupBox1.Controls.Add(txtNombreProducto);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(26, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 246);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de productos";
            // 
            // dgvRegistroProductos
            // 
            dgvRegistroProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistroProductos.Location = new Point(474, 88);
            dgvRegistroProductos.Name = "dgvRegistroProductos";
            dgvRegistroProductos.RowHeadersWidth = 62;
            dgvRegistroProductos.Size = new Size(511, 299);
            dgvRegistroProductos.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(31, 353);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(189, 353);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(342, 353);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 34);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(474, 39);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 5;
            label1.Text = "Productos a registrar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(506, 398);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 6;
            label2.Text = "TOTAL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 54);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 7;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 95);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 8;
            label4.Text = "Costo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 139);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 9;
            label5.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 184);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 10;
            label6.Text = "Unidades:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(194, 184);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 11;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(194, 48);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(180, 31);
            txtNombreProducto.TabIndex = 12;
            txtNombreProducto.KeyPress += txtNombreProducto_KeyPress;
            // 
            // txtCostoProducto
            // 
            txtCostoProducto.Location = new Point(194, 95);
            txtCostoProducto.Name = "txtCostoProducto";
            txtCostoProducto.Size = new Size(180, 31);
            txtCostoProducto.TabIndex = 13;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(194, 139);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(180, 31);
            txtPrecio.TabIndex = 14;
            // 
            // FormInicializacionInventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 496);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnRegistrar);
            Controls.Add(dgvRegistroProductos);
            Controls.Add(groupBox1);
            Name = "FormInicializacionInventario";
            Text = "FormInicializacionInventario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvRegistroProductos;
        private Button btnRegistrar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label2;
        private TextBox txtPrecio;
        private TextBox txtCostoProducto;
        private TextBox txtNombreProducto;
        private NumericUpDown numericUpDown1;
    }
}