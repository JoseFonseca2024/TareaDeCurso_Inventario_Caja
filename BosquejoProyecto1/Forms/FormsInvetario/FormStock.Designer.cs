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
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(209, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(669, 301);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(lblExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1015, 51);
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
            lblExit.Location = new Point(985, 9);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(27, 25);
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
            lblIngresos.Location = new Point(466, 55);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(128, 50);
            lblIngresos.TabIndex = 13;
            lblIngresos.Text = "Stock";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBucarNombre);
            groupBox1.Controls.Add(btnBuscarporID);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft PhagsPa", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(178, 425);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(742, 117);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda";
            // 
            // btnBucarNombre
            // 
            btnBucarNombre.ForeColor = SystemColors.ActiveCaptionText;
            btnBucarNombre.Location = new Point(472, 32);
            btnBucarNombre.Margin = new Padding(3, 4, 3, 4);
            btnBucarNombre.Name = "btnBucarNombre";
            btnBucarNombre.Size = new Size(184, 37);
            btnBucarNombre.TabIndex = 4;
            btnBucarNombre.Text = "Buscar por Nombre";
            btnBucarNombre.UseVisualStyleBackColor = true;
            // 
            // btnBuscarporID
            // 
            btnBuscarporID.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscarporID.Location = new Point(99, 32);
            btnBuscarporID.Margin = new Padding(3, 4, 3, 4);
            btnBuscarporID.Name = "btnBuscarporID";
            btnBuscarporID.Size = new Size(184, 37);
            btnBuscarporID.TabIndex = 4;
            btnBuscarporID.Text = "Buscar por ID";
            btnBuscarporID.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(450, 77);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(138, 32);
            comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(213, 77);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 32);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(367, 82);
            label2.Name = "label2";
            label2.Size = new Size(83, 24);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(97, 78);
            label1.Name = "label1";
            label1.Size = new Size(98, 24);
            label1.TabIndex = 0;
            label1.Text = "Codigo ID:";
            // 
            // FormStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1015, 588);
            Controls.Add(groupBox1);
            Controls.Add(lblIngresos);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
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
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
    }
}