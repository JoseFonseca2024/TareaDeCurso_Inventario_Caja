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
                    Total = d.Cantidad * d.PrecioconIVA
                }).ToList()
            }).ToListAsync();
        }

        // GET: api/Facturas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Factura>> GetFactura(int id)
        {
            var factura = await _context.Facturas.FindAsync(id);

            if (factura == null)
            {
                return NotFound();
            }

            return factura;
        }

        // PUT: api/Facturas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFactura(int id, Factura factura)
        {
            if (id != factura.FacturaID)
            {
                return BadRequest();
            }

            _context.Entry(factura).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacturaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Facturas
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
            decimal IVA = Convert.ToDecimal(0.15);

            foreach (var detalleDTO in dto.Detalles)
            {
                var producto = await _context.Productos.FindAsync(detalleDTO.ProductoID);
                if (producto == null)
                {
                    return BadRequest($"Producto con ID {detalleDTO.ProductoID} no encontrado.");
                }

                producto.Cantidad -= detalleDTO.Cantidad;
                decimal precioConIVA = producto.PrecioconIVA;
                decimal precioSinIVA = precioConIVA / (1 + IVA);

                var detalle = new DetalleFactura
                {
                    ProductoID = detalleDTO.ProductoID,
                    Cantidad = detalleDTO.Cantidad,
                    PrecioconIVA = precioConIVA
                };

                subtotal += precioSinIVA * detalle.Cantidad;
                factura.Detalles.Add(detalle);
            }

            factura.Subtotal = Math.Round(subtotal, 2);
            factura.IVA = Math.Round(factura.Subtotal * IVA, 2);
            factura.Total = factura.Subtotal + factura.IVA;

            _context.Facturas.Add(factura);
            await _context.SaveChangesAsync();

            var caja = await _context.Cajas.Include(c => c.Movimientos).FirstOrDefaultAsync(c => c.FechaCierre == null);

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

            return CreatedAtAction(nameof(GetFactura), new { id = factura.FacturaID }, factura);
        }

        // DELETE: api/Facturas/5
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

            return NoContent();
        }

        private bool FacturaExists(int id)
        {
            return _context.Facturas.Any(e => e.FacturaID == id);
        }
    }
}
