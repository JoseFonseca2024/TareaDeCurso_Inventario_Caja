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
            lblContadorIngresos = new Label();
            lblMontoIngresoso = new Label();
            dgvEgresos = new DataGridView();
            label3 = new Label();
            lblContadorEgresos = new Label();
            lblEgresosMonto = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEgresos).BeginInit();
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
            // lblContadorIngresos
            // 
            lblContadorIngresos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblContadorIngresos.AutoSize = true;
            lblContadorIngresos.BackColor = Color.Transparent;
            lblContadorIngresos.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContadorIngresos.ForeColor = SystemColors.ActiveCaptionText;
            lblContadorIngresos.Location = new Point(18, 479);
            lblContadorIngresos.Name = "lblContadorIngresos";
            lblContadorIngresos.Size = new Size(171, 21);
            lblContadorIngresos.TabIndex = 12;
            lblContadorIngresos.Text = "Cantidad de ingresos";
            // 
            // lblMontoIngresoso
            // 
            lblMontoIngresoso.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMontoIngresoso.AutoSize = true;
            lblMontoIngresoso.BackColor = Color.Transparent;
            lblMontoIngresoso.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMontoIngresoso.ForeColor = SystemColors.ActiveCaptionText;
            lblMontoIngresoso.Location = new Point(18, 512);
            lblMontoIngresoso.Name = "lblMontoIngresoso";
            lblMontoIngresoso.Size = new Size(158, 21);
            lblMontoIngresoso.TabIndex = 13;
            lblMontoIngresoso.Text = "Monto de ingresos:";
            // 
            // dgvEgresos
            // 
            dgvEgresos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEgresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEgresos.Location = new Point(552, 116);
            dgvEgresos.Name = "dgvEgresos";
            dgvEgresos.Size = new Size(510, 347);
            dgvEgresos.TabIndex = 11;
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
            // lblContadorEgresos
            // 
            lblContadorEgresos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblContadorEgresos.AutoSize = true;
            lblContadorEgresos.BackColor = Color.Transparent;
            lblContadorEgresos.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContadorEgresos.ForeColor = SystemColors.ActiveCaptionText;
            lblContadorEgresos.Location = new Point(552, 479);
            lblContadorEgresos.Name = "lblContadorEgresos";
            lblContadorEgresos.Size = new Size(166, 21);
            lblContadorEgresos.TabIndex = 12;
            lblContadorEgresos.Text = "Cantidad de egresos";
            // 
            // lblEgresosMonto
            // 
            lblEgresosMonto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblEgresosMonto.AutoSize = true;
            lblEgresosMonto.BackColor = Color.Transparent;
            lblEgresosMonto.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEgresosMonto.ForeColor = SystemColors.ActiveCaptionText;
            lblEgresosMonto.Location = new Point(552, 512);
            lblEgresosMonto.Name = "lblEgresosMonto";
            lblEgresosMonto.Size = new Size(153, 21);
            lblEgresosMonto.TabIndex = 13;
            lblEgresosMonto.Text = "Monto de egresos:";
            // 
            // FormVerRegistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1085, 550);
            Controls.Add(lblEgresosMonto);
            Controls.Add(lblMontoIngresoso);
            Controls.Add(lblContadorEgresos);
            Controls.Add(lblContadorIngresos);
            Controls.Add(dgvEgresos);
            Controls.Add(dgvIngresos);
            Controls.Add(label3);
            Controls.Add(lblIngresos);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVerRegistros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVerIngresos";
            Load += FormVerRegistros_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEgresos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExit;
        private Panel panel2;
        private Label lblIngresos;
        private DataGridView dgvIngresos;
        private Label lblContadorIngresos;
        private Label lblMontoIngresoso;
        private DataGridView dgvEgresos;
        private Label label3;
        private Label lblContadorEgresos;
        private Label lblEgresosMonto;
    }
}