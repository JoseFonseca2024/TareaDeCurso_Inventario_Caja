using APISistemaCaja_Inventario.Data;
using APISistemaCaja_Inventario.DTO_s.Compra;
using APISistemaCaja_Inventario.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult<IEnumerable<CompraREAD>>> GetCompras()
        {
            return await _context.Compras.Include(e => e.Detalles).Select(e => new CompraREAD
            {
                CompraID = e.CompraID,
                Fecha = e.Fecha,
                Subtotal = e.Subtotal,
                IVA = e.IVA,
                Total = e.Total,
                Detalles = e.Detalles.Select(e => new DetalleCompraREAD
                {
                    DetalleCompraID = e.DetalleCompraID,
                    ProductoID = e.ProductoID,
                    NombreProducto = e.Producto.NombreProducto,
                    Cantidad = e.Cantidad,
                    CostoUnitario = e.CostoUnitario,
                    IVAUnitario = e.IVA_Acreditable_Unitario,
                    Total = e.Total
                }).ToList()
            }).ToListAsync();
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
            decimal IVA = Convert.ToDecimal(0.15);

            var compra = new Compra
            {
                Fecha = dto.Fecha,
                Detalles = new List<DetalleCompra>()
            };

            decimal subtotal = 0;

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

                decimal ivaunitario = producto.CostoProducto * IVA;

                var detalle = new DetalleCompra
                {
                    ProductoID = detalleDTO.ProductoID,
                    Cantidad = detalleDTO.Cantidad,
                    CostoUnitario = producto.CostoProducto,
                    IVA_Acreditable_Unitario = ivaunitario
                };

                compra.Detalles.Add(detalle);

                subtotal += producto.CostoProducto * detalleDTO.Cantidad;
            }

            compra.Subtotal = Math.Round(subtotal, 2);
            compra.IVA = Math.Round(compra.Subtotal * IVA, 2);
            compra.Total = compra.Subtotal + compra.IVA;

            _context.Compras.Add(compra);
            await _context.SaveChangesAsync();


            // Registrar egreso en caja
            var caja = await _context.Cajas.FirstOrDefaultAsync();
            if (caja == null)
                return BadRequest("No existe caja para registrar el egreso.");

            if (caja.Saldo <= 0)
                return BadRequest("La caja está cerrada o sin saldo disponible para registrar egresos.");

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
