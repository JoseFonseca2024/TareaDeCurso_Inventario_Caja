using BosquejoProyecto1.Class;

namespace BosquejoProyecto1.Forms.FormsFacturación
{
    public partial class FormDetallePago : Form
    {

        private readonly decimal _subtotal;
        private readonly decimal _iva;
        private readonly decimal _total;
        private readonly decimal _pagado;
        private readonly decimal _cambio;
        private readonly FormService _formService = new FormService();
        public FormDetallePago(decimal total, decimal pagado)
        {
            InitializeComponent();
            _formService.CambiodeColor(lblSalir);
            _formService.CerrarSinValidar(lblSalir, this);

            _total = total;
            _iva = Math.Round(total * 0.15m, 2);
            _subtotal = total - _iva;
            _pagado = pagado;
            _cambio = pagado - total;

            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            lblSubtotal.Text = $"Subtotal: C$ {_subtotal:N2}";
            lblIva.Text = $"IVA (15%): C$ {_iva:N2}";
            lblTotal.Text = $"Total: C$ {_total:N2}";
            lblPago.Text = $"Pagado con: C$ {_pagado:N2}";
            lblCambio.Text = $"Cambio: C$ {_cambio:N2}";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
