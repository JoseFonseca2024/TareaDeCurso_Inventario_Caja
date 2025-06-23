using BosquejoProyecto1.DTO_s;
using BosquejoProyecto1.DTO_s.Caja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace BosquejoProyecto1.Class
{
    public class CajaService
    {
        public async Task<bool> ExistenciadeCaja(HttpClient client, string url)
        {
            try
            {
                var cajas = await client.GetFromJsonAsync<List<CajaDTO>>(url);
                if (cajas != null)
                {
                    if (cajas.Any())
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

        public async Task<decimal> CargarSaldo(HttpClient client, string url)
        {
            try
            {
                var cajas = await client.GetFromJsonAsync<List<CajaDTO>>(url);
                var cajaAbierta = cajas?.FirstOrDefault();
                if (cajaAbierta != null)
                {
                    return cajaAbierta.Saldo;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public async Task InicializarSaldo(Form form, TextBox txt, Label lbl, string url, HttpClient client)
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

        public async Task<List<MovimientoEnCajaREAD>> ObtenerIngresos(HttpClient client, string url, Label lbl, Label lbl2)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            options.Converters.Add(new JsonStringEnumConverter());

            var stream = await client.GetStreamAsync(url);
            var movimientos = await JsonSerializer.DeserializeAsync<List<MovimientoEnCajaREAD>>(stream, options);

            var ingresos = movimientos?
                .Where(m => m.Tipo == TipodeMovimiento.Ingreso)
                .ToList() ?? new List<MovimientoEnCajaREAD>();

            lbl.Text = $"Cantidad de ingresos: {ingresos.Count}";
            lbl2.Text = $"Monto de ingresos: C$ {ingresos.Sum(i => i.Monto):N2}";

            return ingresos;
        }

        public async Task<List<MovimientoEnCajaREAD>> ObtenerEgresos(HttpClient client, string url, Label lbl, Label lbl2)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            options.Converters.Add(new JsonStringEnumConverter());

            var stream = await client.GetStreamAsync(url);
            var movimientos = await JsonSerializer.DeserializeAsync<List<MovimientoEnCajaREAD>>(stream, options);

            var egresos = movimientos?
                .Where(m => m.Tipo == TipodeMovimiento.Egreso)
                .ToList() ?? new List<MovimientoEnCajaREAD>();

            lbl.Text = $"Cantidad de egresos: {egresos.Count}";
            lbl2.Text = $"Monto de egresos: C$ {egresos.Sum(e => e.Monto):N2}";

            return egresos;
        }

        public decimal SumarDenominaciones(params TextBox[] textos)
        {
            decimal[] denominaciones = { 1, 5, 10, 20, 50, 100, 200, 500, 1000 };
            decimal suma = 0m;

            for (int i = 0; i < textos.Length && i < denominaciones.Length; i++)
            {
                if (decimal.TryParse(textos[i].Text, out decimal cantidad))
                {
                    suma += cantidad * denominaciones[i];
                }
            }

            return suma;
        }

        public bool ValidarCampos(params TextBox[] textos)
        {
            foreach (var txt in textos)
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    MessageBox.Show($"El campo {txt.Name} está vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (!decimal.TryParse(txt.Text, out _))
                {
                    MessageBox.Show($"El campo {txt.Name} contiene un valor inválido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public async Task CerrarCaja(Form form, string url, HttpClient client)
        {
            var cajas = await client.GetFromJsonAsync<List<CajaDTO>>(url);
            var caja = cajas?.FirstOrDefault();

            var actualizarCaja = new CajaUPDATE
            {
                Saldo = 0
            };

            var response = await client.PutAsJsonAsync($"{url}/{caja.CajaID}", actualizarCaja);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Caja cerrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form.Close();
            }
            else
            {
                MessageBox.Show("Error al cerrar la caja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
   
