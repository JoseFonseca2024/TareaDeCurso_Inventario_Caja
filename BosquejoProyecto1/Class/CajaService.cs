using BosquejoProyecto1.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BosquejoProyecto1.Class
{
    public class CajaService
    {
        public async Task CargarSaldo(TextBox txt, HttpClient client, string url)
        {
            try
            {
                var cajas = await client.GetFromJsonAsync<List<CajaDTO>>(url);
                var cajaAbierta = cajas?.FirstOrDefault();
                if (cajaAbierta != null)
                    txt.Text = $"C$ {cajaAbierta.Saldo}";
                else
                    txt.Text = "C$ -";
            }
            catch
            {
                txt.Text = "C$ -";
            }
        }

        public async Task InicializarSaldo(Form form,TextBox txt,Label lbl, string url, HttpClient client)
        {
            try
            {
                if (string.IsNullOrEmpty(txt.Text))
                {
                    lbl.Visible = true;
                    lbl.Text = "Ingrese un valor al saldo";
                    return;
                }
                else
                {
                    var cajas = await client.GetFromJsonAsync<List<CajaDTO>>(url);
                    var cajaExistente = cajas?.FirstOrDefault();

                    if (cajaExistente == null)
                    {
                        // No existe caja, se crea una nueva (POST)
                        var nuevaCaja = new CajaCREATE
                        {
                            Saldo = Convert.ToDecimal(txt.Text)
                        };

                        var response = await client.PostAsJsonAsync(url, nuevaCaja);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Caja inicializada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            form.Close();
                        }

                    }
                    else if (cajaExistente.Saldo == 0)
                    {
                        // Actualizar caja existente
                        var actualizarCaja = new CajaUPDATE
                        {
                            Saldo = Convert.ToDecimal(txt.Text)
                        };

                        var response = await client.PutAsJsonAsync($"{url}/{cajaExistente.CajaID}", actualizarCaja);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Caja existente actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            form.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Ya hay una caja con saldo. No es posible inicializar nuevamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    form.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
