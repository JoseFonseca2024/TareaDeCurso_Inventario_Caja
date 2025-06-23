using BosquejoProyecto1.DTO_s.Producto;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BosquejoProyecto1.Class
{
    public class ProductoService
    {
        public async void AgregarProducto(TextBox txtNombre, TextBox txtcosto, TextBox txtPrecio, NumericUpDown cantidad, DataGridView dg, string url, HttpClient cliente)
        {
            var nuevoprodcuto = new ProductoCREATE
            {
                NombreProducto = txtNombre.Text,
                CostoProducto = Convert.ToDecimal(txtcosto.Text),
                PrecioConIVA = Convert.ToDecimal(txtPrecio.Text),
                Cantidad = Convert.ToInt32(cantidad.Value)
            };
            var response = await cliente.PostAsJsonAsync(url, nuevoprodcuto);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Producto Agregado Correctamente");
                CargarProducto(dg, url, cliente);
            }

        }

        public async void CargarProducto(DataGridView dg, string url, HttpClient client)
        {
            var productos = await client.GetFromJsonAsync<List<ProductoREAD>>(url);
            dg.DataSource = productos;
        }

        public async void ActualizarProducto (DataGridView dg,TextBox txtnombre, TextBox txtCosto, TextBox txtPrecio, NumericUpDown cantidad, string url, HttpClient client)
        {
            if (dg.CurrentRow == null)
            {
                MessageBox.Show("Seleccione el producto a Actualizar", "Seleccion nula", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                var producto = (ProductoREAD)dg.CurrentRow.DataBoundItem;
                producto.NombreProducto = txtnombre.Text;
                producto.CostoProducto = Convert.ToDecimal(txtCosto.Text);
                producto.PrecioConIVA = Convert.ToDecimal(txtPrecio.Text);
                producto.Cantidad = Convert.ToInt32(cantidad.Value);
                var response = await client.PutAsJsonAsync($"{url}/{producto.ProductoID}", producto);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto actualizado correctamente", "Actiualizacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProducto(dg, url, client);
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(error);
                }
            }
        }

        public async void EliminarProducto(DataGridView dg, TextBox txtnombre, TextBox txtCosto, TextBox txtPrecio, NumericUpDown cantidad, string url, HttpClient client)
        {
            if (dg.CurrentRow == null)
            {
                MessageBox.Show("Seleccione el producto a Eliminar", "Seleccion nula", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                var producto = (ProductoREAD)dg.CurrentRow.DataBoundItem;
                var response = await client.DeleteAsync($"{url}/{producto.ProductoID}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto eliminado correctamente", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProducto(dg, url, client);
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(error);
                }
            }
        }

        public async Task<bool> ExistenciadeInventario(HttpClient client, string url)
        {
            try 
            
            {
                var inventario = await client.GetFromJsonAsync<List<ProductoREAD>>(url);
                if (inventario != null)
                {
                    if (inventario.Any())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else 
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        public async Task BuscarProductoporNombre (string nombre , DataGridView dgv, HttpClient client, string url)
        {
            try
            {
                var productos = await client.GetFromJsonAsync<List<ProductoREAD>>(url);

                if (productos != null)
                {
                    var filtro = productos
                        .Where(p => !string.IsNullOrWhiteSpace(p.NombreProducto) &&
                                    p.NombreProducto.Contains(nombre, StringComparison.OrdinalIgnoreCase))
                        .ToList();

                    if (filtro.Any())
                    {
                        dgv.DataSource = null;
                        dgv.DataSource = filtro;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron productos con ese nombre.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgv.DataSource = null;
                    }
                }
                else
                {
                    MessageBox.Show("No se pudieron cargar los productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public async Task BuscarProductoporID(NumericUpDown idproducto, DataGridView dgv, HttpClient client, string url)
        {
            try
            {
                int id = Convert.ToInt32(idproducto.Value);
                var producto = await client.GetFromJsonAsync<ProductoREAD>($"{url}/{id}");

                if (producto != null)
                {
                    dgv.DataSource = null;
                    dgv.DataSource = new List<ProductoREAD> { producto };
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.", "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgv.DataSource = null;
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Error de conexión con la API.");
            }

        }

        public async Task<decimal> ObtenerValorInventario(HttpClient client, string url)
        {
            try
            {
                var productos = await client.GetFromJsonAsync<List<ProductoREAD>>(url);

                if (productos == null || !productos.Any())
                    return 0;

                decimal total = productos.Sum(p => p.CostoProducto * p.Cantidad);
                return total;
            }
            catch
            {
                return 0;
            }
        }

    }
}
