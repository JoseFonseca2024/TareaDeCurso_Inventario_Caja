namespace BosquejoProyecto1.Forms.FormsFacturación
{
    partial class FormsPago
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
            txtPago = new TextBox();
            panel2 = new Panel();
            lblExit = new Label();
            label1 = new Label();
            btnAceptar = new Button();
            btn100 = new Button();
            btn200 = new Button();
            btn500 = new Button();
            btn1000 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtPago
            // 
            txtPago.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPago.Location = new Point(115, 63);
            txtPago.Name = "txtPago";
            txtPago.Size = new Size(159, 27);
            txtPago.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(lblExit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 38);
            panel2.TabIndex = 9;
            // 
            // lblExit
            // 
            lblExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblExit.AutoSize = true;
            lblExit.BackColor = Color.Transparent;
            lblExit.Cursor = Cursors.Hand;
            lblExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.ForeColor = SystemColors.Control;
            lblExit.Location = new Point(381, 9);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(21, 20);
            lblExit.TabIndex = 1;
            lblExit.Text = "X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(24, 67);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 10;
            label1.Text = "Paga con:";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(287, 59);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(90, 34);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btn100
            // 
            btn100.Font = new Font("Segoe UI", 14.25F);
            btn100.Location = new Point(24, 119);
            btn100.Name = "btn100";
            btn100.Size = new Size(162, 63);
            btn100.TabIndex = 12;
            btn100.Text = "100";
            btn100.UseVisualStyleBackColor = true;
            // 
            // btn200
            // 
            btn200.Font = new Font("Segoe UI", 14.25F);
            btn200.Location = new Point(192, 119);
            btn200.Name = "btn200";
            btn200.Size = new Size(174, 63);
            btn200.TabIndex = 12;
            btn200.Text = "200";
            btn200.UseVisualStyleBackColor = true;
            // 
            // btn500
            // 
            btn500.Font = new Font("Segoe UI", 14.25F);
            btn500.Location = new Point(24, 188);
            btn500.Name = "btn500";
            btn500.Size = new Size(162, 68);
            btn500.TabIndex = 12;
            btn500.Text = "500";
            btn500.UseVisualStyleBackColor = true;
            // 
            // btn1000
            // 
            btn1000.Font = new Font("Segoe UI", 14.25F);
            btn1000.Location = new Point(192, 188);
            btn1000.Name = "btn1000";
            btn1000.Size = new Size(174, 68);
            btn1000.TabIndex = 12;
            btn1000.Text = "1000";
            btn1000.UseVisualStyleBackColor = true;
            // 
            // FormsPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(405, 283);
            Controls.Add(btn1000);
            Controls.Add(btn500);
            Controls.Add(btn200);
            Controls.Add(btn100);
            Controls.Add(btnAceptar);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(txtPago);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormsPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormsPago";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPago;
        private Panel panel2;
        private Label lblExit;
        private Label label1;
        private Button btnAceptar;
        private Button btn100;
        private Button btn200;
        private Button btn500;
        private Button btn1000;
    }
}