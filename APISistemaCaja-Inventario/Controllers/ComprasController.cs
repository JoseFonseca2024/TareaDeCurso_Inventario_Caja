using APISistemaCaja_Inventario.Data;
using APISistemaCaja_Inventario.DTO_s.Compra;
using APISistemaCaja_Inventario.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISistemaCaja_Inventario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprasController : ControllerBase
    {
        private readonly Sistema_Context _context;

        public ComprasController(Sistema_Context context)
        {
            _context = context;
        }

        // GET: api/Compras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Compra>>> GetCompras()
        {
            return await _context.Compras.ToListAsync();
        }

        // GET: api/Compras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Compra>> GetCompra(int id)
        {
            var compra = await _context.Compras.FindAsync(id);

            if (compra == null)
            {
                return NotFound();
            }

            return compra;
        }

        // PUT: api/Compras/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompra(int id, Compra compra)
        {
            if (id != compra.CompraID)
            {
                return BadRequest();
            }

            _context.Entry(compra).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompraExists(id))
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

        // POST: api/Compras
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult> PostCompra(CompraCREATE dto)
        {
            var compra = new Compra
            {
                Fecha = dto.Fecha,
                Detalles = new List<DetalleCompra>()
            };

            decimal subtotal = 0;
            decimal IVA = 0.15m;

            foreach (var detalleDTO in dto.Detalles)
            {
                var producto = await _context.Productos.FindAsync(detalleDTO.ProductoID);

                if (producto == null)
                {
                    // Si manejas creación de productos nuevos, aquí puedes hacerlo
                    return BadRequest($"Producto con ID {detalleDTO.ProductoID} no encontrado.");
                }

                // Actualizar inventario: sumar cantidad comprada
                producto.Cantidad += detalleDTO.Cantidad;

                var detalle = new DetalleCompra
                {
                    ProductoID = detalleDTO.ProductoID,
                    Cantidad = detalleDTO.Cantidad,
                    PrecioUnitario = producto.CostoProducto
                };

                compra.Detalles.Add(detalle);

                subtotal += producto.CostoProducto * detalleDTO.Cantidad;
            }

            compra.Subtotal = Math.Round(subtotal, 2);
            compra.IVA = Math.Round(compra.Subtotal * IVA, 2);
            compra.Total = compra.Subtotal + compra.IVA;

            _context.Compras.Add(compra);

            // Registrar egreso en caja
            var caja = await _context.Cajas.FirstOrDefaultAsync(c => c.FechaCierre == null);
            if (caja == null)
                return BadRequest("No existe caja abierta para registrar el egreso.");

            var movimientoCaja = new MovimientoCaja
            {
                CajaID = caja.CajaID,
                Tipo = TipodeMovimiento.Egreso,
                Monto = compra.Total,
                Concepto = $"Egreso por compra según Compra #{compra.CompraID}",
                Fecha = DateTime.Now
            };
            _context.MovimientosCaja.Add(movimientoCaja);

            // Actualizar saldo de caja
            caja.Saldo -= compra.Total;
            _context.Cajas.Update(caja);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCompra), new { id = compra.CompraID }, compra);
        }

        // DELETE: api/Compras/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompra(int id)
        {
            var compra = await _context.Compras.FindAsync(id);
            if (compra == null)
            {
                return NotFound();
            }

            _context.Compras.Remove(compra);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompraExists(int id)
        {
            return _context.Compras.Any(e => e.CompraID == id);
        }
    }
}
