using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APISistemaCaja_Inventario.Data;
using APISistemaCaja_Inventario.Models;

namespace APISistemaCaja_Inventario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CajasController : ControllerBase
    {
        private readonly Sistema_Context _context;

        public CajasController(Sistema_Context context)
        {
            _context = context;
        }

        // GET: api/Cajas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Caja>>> GetCajas()
        {
            return await _context.Cajas.ToListAsync();
        }

        // GET: api/Cajas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Caja>> GetCaja(int id)
        {
            var caja = await _context.Cajas.FindAsync(id);

            if (caja == null)
            {
                return NotFound();
            }

            return caja;
        }

        // PUT: api/Cajas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCaja(int id, Caja caja)
        {
            if (id != caja.CajaID)
            {
                return BadRequest();
            }

            _context.Entry(caja).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CajaExists(id))
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

        // POST: api/Cajas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Caja>> PostCaja(Caja caja)
        {
            _context.Cajas.Add(caja);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCaja", new { id = caja.CajaID }, caja);
        }

        // DELETE: api/Cajas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCaja(int id)
        {
            var caja = await _context.Cajas.FindAsync(id);
            if (caja == null)
            {
                return NotFound();
            }

            _context.Cajas.Remove(caja);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CajaExists(int id)
        {
            return _context.Cajas.Any(e => e.CajaID == id);
        }
    }
}
