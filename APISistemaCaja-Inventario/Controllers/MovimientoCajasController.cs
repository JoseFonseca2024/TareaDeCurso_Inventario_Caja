using APISistemaCaja_Inventario.Data;
using APISistemaCaja_Inventario.DTO_s.Caja;
using APISistemaCaja_Inventario.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APISistemaCaja_Inventario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimientoCajasController : ControllerBase
    {
        private readonly Sistema_Context _context;

        public MovimientoCajasController(Sistema_Context context)
        {
            _context = context;
        }

        // GET: api/MovimientoCajas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovimientoEnCajaREAD>>> GetMovimientosCaja()
        {
            return await _context.MovimientosCaja.Select(e => new MovimientoEnCajaREAD
            {
                MovimientoID = e.MovimientoID,
                Tipo = e.Tipo,
                Concepto = e.Concepto,
                Monto = e.Monto,
                Fecha = e.Fecha,
            }).ToListAsync();
        }

        // GET: api/MovimientoCajas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovimientoCaja>> GetMovimientoCaja(int id)
        {
            var movimientoCaja = await _context.MovimientosCaja.FindAsync(id);

            if (movimientoCaja == null)
            {
                return NotFound();
            }

            return movimientoCaja;
        }

        // PUT: api/MovimientoCajas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovimientoCaja(int id, MovimientoCaja movimientoCaja)
        {
            if (id != movimientoCaja.MovimientoID)
            {
                return BadRequest();
            }

            _context.Entry(movimientoCaja).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovimientoCajaExists(id))
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

        // POST: api/MovimientoCajas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MovimientoCaja>> PostMovimientoCaja(MovimientoCaja movimientoCaja)
        {
            _context.MovimientosCaja.Add(movimientoCaja);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovimientoCaja", new { id = movimientoCaja.MovimientoID }, movimientoCaja);
        }

        // DELETE: api/MovimientoCajas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovimientoCaja(int id)
        {
            var movimientoCaja = await _context.MovimientosCaja.FindAsync(id);
            if (movimientoCaja == null)
            {
                return NotFound();
            }

            _context.MovimientosCaja.Remove(movimientoCaja);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MovimientoCajaExists(int id)
        {
            return _context.MovimientosCaja.Any(e => e.MovimientoID == id);
        }
    }
}
