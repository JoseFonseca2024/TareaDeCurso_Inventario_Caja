namespace BosquejoProyecto1.Forms.FormsFacturación
{
    partial class FormDetallePago
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
            lblSalir = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(lblSalir);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 35);
            panel2.TabIndex = 24;
            // 
            // lblSalir
            // 
            lblSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSalir.AutoSize = true;
            lblSalir.BackColor = Color.Transparent;
            lblSalir.Cursor = Cursors.Hand;
            lblSalir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalir.ForeColor = SystemColors.Control;
            lblSalir.Location = new Point(371, 9);
            lblSalir.Name = "lblSalir";
            lblSalir.Size = new Size(21, 20);
            lblSalir.TabIndex = 2;
            lblSalir.Text = "X";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(14, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 292);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle Pago";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Lavender;
            label5.Font = new Font("Segoe UI", 20.25F);
            label5.Location = new Point(29, 239);
            label5.Name = "label5";
            label5.Size = new Size(116, 37);
            label5.TabIndex = 0;
            label5.Text = "Cambio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Lavender;
            label4.Font = new Font("Segoe UI", 20.25F);
            label4.Location = new Point(29, 186);
            label4.Name = "label4";
            label4.Size = new Size(163, 37);
            label4.TabIndex = 0;
            label4.Text = "Pagado con:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Lavender;
            label3.Font = new Font("Segoe UI", 20.25F);
            label3.Location = new Point(29, 135);
            label3.Name = "label3";
            label3.Size = new Size(175, 37);
            label3.TabIndex = 0;
            label3.Text = "Total a Pagar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Lavender;
            label2.Font = new Font("Segoe UI", 20.25F);
            label2.Location = new Point(29, 83);
            label2.Name = "label2";
            label2.Size = new Size(62, 37);
            label2.TabIndex = 0;
            label2.Text = "IVA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lavender;
            label1.Font = new Font("Segoe UI", 20.25F);
            label1.Location = new Point(29, 36);
            label1.Name = "label1";
            label1.Size = new Size(125, 37);
            label1.TabIndex = 0;
            label1.Text = "SubTotal:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(131, 361);
            button1.Name = "button1";
            button1.Size = new Size(111, 38);
            button1.TabIndex = 26;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormDetallePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(395, 427);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDetallePago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDetallePago";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblSalir;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}