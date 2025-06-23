namespace BosquejoProyecto1.Forms.FormsInvetario
{
    partial class FormStock
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            lblExit = new Label();
            lblIngresos = new Label();
            groupBox1 = new GroupBox();
            btnBucarNombre = new Button();
            btnBuscarporID = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 91);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(649, 279);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(lblExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 38);
            panel1.TabIndex = 1;
            // 
            // lblExit
            // 
            lblExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblExit.AutoSize = true;
            lblExit.BackColor = Color.Transparent;
            lblExit.Cursor = Cursors.Hand;
            lblExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.ForeColor = SystemColors.Control;
            lblExit.Location = new Point(673, 7);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(21, 20);
            lblExit.TabIndex = 2;
            lblExit.Text = "X";
            // 
            // lblIngresos
            // 
            lblIngresos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblIngresos.AutoSize = true;
            lblIngresos.BackColor = Color.Transparent;
            lblIngresos.Font = new Font("Microsoft JhengHei", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngresos.ForeColor = SystemColors.ActiveCaptionText;
            lblIngresos.Location = new Point(305, 43);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(103, 40);
            lblIngresos.TabIndex = 13;
            lblIngresos.Text = "Stock";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnBucarNombre);
            groupBox1.Controls.Add(btnBuscarporID);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft PhagsPa", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(31, 385);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(649, 102);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda";
            // 
            // btnBucarNombre
            // 
            btnBucarNombre.ForeColor = SystemColors.ActiveCaptionText;
            btnBucarNombre.Location = new Point(354, 21);
            btnBucarNombre.Name = "btnBucarNombre";
            btnBucarNombre.Size = new Size(161, 28);
            btnBucarNombre.TabIndex = 4;
            btnBucarNombre.Text = "Buscar por Nombre";
            btnBucarNombre.UseVisualStyleBackColor = true;
            // 
            // btnBuscarporID
            // 
            btnBuscarporID.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscarporID.Location = new Point(354, 53);
            btnBuscarporID.Name = "btnBuscarporID";
            btnBuscarporID.Size = new Size(161, 28);
            btnBuscarporID.TabIndex = 4;
            btnBuscarporID.Text = "Buscar por ID";
            btnBuscarporID.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(142, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 28);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(56, 28);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(56, 61);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Codigo ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 27);
            textBox1.TabIndex = 5;
            // 
            // FormStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(699, 508);
            Controls.Add(groupBox1);
            Controls.Add(lblIngresos);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormStock";
            Text = "FormStock";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label lblExit;
        private Label lblIngresos;
        private GroupBox groupBox1;
        private Button btnBucarNombre;
        private Button btnBuscarporID;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
    }
}