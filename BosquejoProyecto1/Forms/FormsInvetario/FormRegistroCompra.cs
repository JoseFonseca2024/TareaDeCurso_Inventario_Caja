using BosquejoProyecto1.Class;
using BosquejoProyecto1.DTO_s.Producto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BosquejoProyecto1.Forms.FormsInvetario
{
    public partial class FormRegistroCompra : Form
    {
        private readonly FormService _formService = new FormService();
        private readonly ProductoService _productoService = new ProductoService();
        private readonly CompraService _compraService;
        private readonly string urlProductos = "https://localhost:7064/api/Productoes";
        private readonly string urlCompras = "https://localhost:7064/api/Compras";
        private readonly HttpClient client = new HttpClient();

        public FormRegistroCompra()
        {
            InitializeComponent();
            _formService.CambiodeColor(lblExit);
            _formService.CerrarConValidación(lblExit, this);
            _formService.CargarParametros(dgvProductos, txtNombre, txtCosto, txtPrecio, numUnidades);
            _formService.CargarParametros(dgvCompra, txtNombre, txtCosto, txtPrecio, numUnidades);

            _productoService.CargarProducto(dgvProductos, urlProductos, client);
            _compraService = new CompraService(_productoService);
            cmbExistencia.Items.Add("Nuevo");
            cmbExistencia.Items.Add("Registrado");
        }

        private void Visibilidadparametro(ComboBox cmb, Label lbl, TextBox txt)
        {
            if (cmb.SelectedItem?.ToString() == "Registrado")
            {
                txt.Visible = true;
                lbl.Visible = true;
            }
            else
            {
                txt.Visible = false;
                lbl.Visible = false;
            }
        }

        private void cmbExistencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visibilidadparametro(cmbExistencia, lblID, txtID);
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            await _compraService.AgregarProductoaCompra(
                cmbExistencia,
                txtID,
                txtNombre,
                txtCosto,
                numUnidades,
                dgvCompra,
                label8,
                client
            );
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            _compraService.ActualizarProductoEnFactura(
                txtNombre,
                txtCosto,
                numUnidades,
                dgvCompra,
                label8
            );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _compraService.EliminarProductoDeFactura(dgvCompra, label8);
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            await _compraService.ConfirmarCompraAsync(
                dgvCompra,
                label8,
                client,
                urlCompras,
                urlProductos
            );

            // Refrescar el dgvProductos después de confirmar la compra
            var productos = await client.GetFromJsonAsync<List<ProductoREAD>>(urlProductos);
            dgvProductos.DataSource = productos;
        }
    }
}
