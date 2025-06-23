using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APISistemaCaja_Inventario.Data;
using APISistemaCaja_Inventario.Models;
using APISistemaCaja_Inventario.DTO_s.Factura;
using System.Reflection.Metadata.Ecma335;

namespace APISistemaCaja_Inventario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturasController : ControllerBase
    {
        private readonly Sistema_Context _context;

        public FacturasController(Sistema_Context context)
        {
            _context = context;
        }

        // GET: api/Facturas
        // Retorna todas las facturas con sus detalles y nombre de los productos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FacturaREAD>>> GetFacturas()
        {
            return await _context.Facturas.Include(e => e.Detalles).Select(e => new FacturaREAD
            {
                FacturaID = e.FacturaID,
                Fecha = e.Fecha,
                Subtotal = e.Subtotal,
                IVA = e.IVA,
                Total = e.Total,
                Detalles = e.Detalles.Select(d => new FacturaDETALLE
                {
                    DetalleFacturaID = d.FacturaID,
                    ProductoID = d.ProductoID,
                    NombreProducto = d.Producto.NombreProducto,
                    Cantidad = d.Cantidad,
                    PrecioconIVA = d.PrecioconIVA,
                    Total = d.Total
                }).ToList()
            }).ToListAsync();
        }

        // GET: api/Facturas/5
        // Retorna una factura específica por su ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Factura>> GetFactura(int id)
        {
            var factura = await _context.Facturas.FindAsync(id);

            if (factura == null)
            {
                return NotFound();// Si no se encuentra la factura, retorna 404
            }

            return factura;
        }

        // PUT: api/Facturas/5
        // Actualiza una factura existente (requiere que el ID coincida)
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFactura(int id, Factura factura)
        {
            if (id != factura.FacturaID)
            {
                return BadRequest(); // ID no coincide con el objeto recibido
            }

            _context.Entry(factura).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync(); // Guarda los cambios
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacturaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;// Si es otro error, relanza la excepción
                }
            }

            return NoContent();// Éxito sin contenido
        }

        // POST: api/Facturas
        // Crea una nueva factura, descuenta productos del inventario, registra en caja
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult> PostFactura(FacturaCREATE dto)
        {
            var factura = new Factura
            {
                Fecha = dto.Fecha,
                Detalles = new List<DetalleFactura>()

            };

            decimal subtotal = 0;
            decimal IVA = Convert.ToDecimal(0.15);// IVA del 15%

            // Recorre cada producto de la factura
            foreach (var detalleDTO in dto.Detalles)
            {
                var producto = await _context.Productos.FindAsync(detalleDTO.ProductoID);
                if (producto == null)
                {
                    return BadRequest($"Producto con ID {detalleDTO.ProductoID} no encontrado.");
                }
                // Descuenta el stock
                producto.Cantidad -= detalleDTO.Cantidad;
                decimal precioConIVA = producto.PrecioconIVA;
                decimal precioSinIVA = precioConIVA / (1 + IVA);

                // Crea el detalle de factura
                var detalle = new DetalleFactura
                {
                    ProductoID = detalleDTO.ProductoID,
                    Cantidad = detalleDTO.Cantidad,
                    PrecioconIVA = precioConIVA
                };
                // Acumula subtotal
                subtotal += precioSinIVA * detalle.Cantidad;
                factura.Detalles.Add(detalle);
            }
            // Calcula totales
            factura.Subtotal = Math.Round(subtotal, 2);
            factura.IVA = Math.Round(factura.Subtotal * IVA, 2);
            factura.Total = factura.Subtotal + factura.IVA;
            // Guarda la factura
            _context.Facturas.Add(factura);
            await _context.SaveChangesAsync();
            // Verifica que haya caja activa
            var caja = await _context.Cajas.FirstOrDefaultAsync();
            if (caja == null)
                return BadRequest("No existe caja para registrar el ingreso.");

            // Opcional: validar que caja esté abierta
            if (caja.Saldo < 0)
                return BadRequest("La caja está cerrada.");
            // Registra el ingreso en la caja
            var movimiento = new MovimientoCaja
            {
                Tipo = TipodeMovimiento.Ingreso,
                Concepto = $"Ingreso por venta según factura : {factura.FacturaID}",
                Monto = factura.Total,
                Fecha = DateTime.Now,
                CajaID = caja.CajaID
            };

            caja.Saldo += factura.Total;
            _context.MovimientosCaja.Add(movimiento);
            _context.Cajas.Update(caja);

            await _context.SaveChangesAsync();
            // Retorna la factura creada con ubicación
            return CreatedAtAction(nameof(GetFactura), new { id = factura.FacturaID }, factura);
        }

        // DELETE: api/Facturas/5
        // Elimina una factura por ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFactura(int id)
        {
            var factura = await _context.Facturas.FindAsync(id);
            if (factura == null)
            {
                return NotFound();
            }

            _context.Facturas.Remove(factura);
            await _context.SaveChangesAsync();

            return NoContent(); // Eliminación exitosa
        }
        // Verifica si existe una factura con el ID dado
        private bool FacturaExists(int id)
        {
            return _context.Facturas.Any(e => e.FacturaID == id);
        }
    }
}
