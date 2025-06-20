namespace BosquejoProyecto1.Forms
{
    partial class FormVerRegistros
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
            lblIngresos = new Label();
            dgvIngresos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            lblExit.Location = new Point(1052, 9);
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
            panel2.Size = new Size(1085, 35);
            panel2.TabIndex = 9;
            // 
            // lblIngresos
            // 
            lblIngresos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblIngresos.AutoSize = true;
            lblIngresos.BackColor = Color.Transparent;
            lblIngresos.Font = new Font("Microsoft JhengHei", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngresos.ForeColor = SystemColors.ActiveCaptionText;
            lblIngresos.Location = new Point(196, 61);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(150, 40);
            lblIngresos.TabIndex = 10;
            lblIngresos.Text = "Ingresos";
            // 
            // dgvIngresos
            // 
            dgvIngresos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngresos.Location = new Point(18, 116);
            dgvIngresos.Name = "dgvIngresos";
            dgvIngresos.Size = new Size(510, 347);
            dgvIngresos.TabIndex = 11;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(18, 479);
            label1.Name = "label1";
            label1.Size = new Size(171, 21);
            label1.TabIndex = 12;
            label1.Text = "Cantidad de ingresos";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(18, 512);
            label2.Name = "label2";
            label2.Size = new Size(158, 21);
            label2.TabIndex = 13;
            label2.Text = "Monto de ingresos:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(552, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(510, 347);
            dataGridView1.TabIndex = 11;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft JhengHei", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(738, 61);
            label3.Name = "label3";
            label3.Size = new Size(138, 40);
            label3.TabIndex = 10;
            label3.Text = "Egresos";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(552, 479);
            label4.Name = "label4";
            label4.Size = new Size(166, 21);
            label4.TabIndex = 12;
            label4.Text = "Cantidad de egresos";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(552, 512);
            label5.Name = "label5";
            label5.Size = new Size(153, 21);
            label5.TabIndex = 13;
            label5.Text = "Monto de egresos:";
            // 
            // FormVerRegistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1085, 550);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(dgvIngresos);
            Controls.Add(label3);
            Controls.Add(lblIngresos);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVerRegistros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVerIngresos";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExit;
        private Panel panel2;
        private Label lblIngresos;
        private DataGridView dgvIngresos;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}