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
            lblCambio = new Label();
            lblPago = new Label();
            lblTotal = new Label();
            lblIva = new Label();
            lblSubtotal = new Label();
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
            groupBox1.Controls.Add(lblCambio);
            groupBox1.Controls.Add(lblPago);
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(lblIva);
            groupBox1.Controls.Add(lblSubtotal);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(14, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 292);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle Pago";
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.BackColor = Color.Lavender;
            lblCambio.Font = new Font("Segoe UI", 20.25F);
            lblCambio.Location = new Point(29, 239);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(116, 37);
            lblCambio.TabIndex = 0;
            lblCambio.Text = "Cambio:";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.BackColor = Color.Lavender;
            lblPago.Font = new Font("Segoe UI", 20.25F);
            lblPago.Location = new Point(29, 186);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(163, 37);
            lblPago.TabIndex = 0;
            lblPago.Text = "Pagado con:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Lavender;
            lblTotal.Font = new Font("Segoe UI", 20.25F);
            lblTotal.Location = new Point(29, 135);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(175, 37);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total a Pagar:";
            // 
            // lblIva
            // 
            lblIva.AutoSize = true;
            lblIva.BackColor = Color.Lavender;
            lblIva.Font = new Font("Segoe UI", 20.25F);
            lblIva.Location = new Point(29, 83);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(62, 37);
            lblIva.TabIndex = 0;
            lblIva.Text = "IVA:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.BackColor = Color.Lavender;
            lblSubtotal.Font = new Font("Segoe UI", 20.25F);
            lblSubtotal.Location = new Point(29, 36);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(125, 37);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "SubTotal:";
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
        private Label lblCambio;
        private Label lblPago;
        private Label lblTotal;
        private Label lblIva;
        private Label lblSubtotal;
        private Button button1;
    }
}