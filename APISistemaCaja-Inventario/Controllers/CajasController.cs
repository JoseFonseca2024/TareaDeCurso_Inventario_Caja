using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APISistemaCaja_Inventario.Data;
using APISistemaCaja_Inventario.Models;
using APISistemaCaja_Inventario.DTO_s.Caja;

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
        public async Task<ActionResult<IEnumerable<CajaDTO>>> GetCajas()
        {
            return await _context.Cajas.Select(e => new CajaDTO
            {
                CajaID = e.CajaID,
                Saldo = e.Saldo,
            }).ToListAsync();
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
        public async Task<IActionResult> PutCaja(int id, CajaUPDATE dto)
        {
            var caja = await _context.Cajas.FindAsync(id);
            if (caja == null) return NotFound();

            caja.Saldo = dto.Saldo;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Cajas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult> PostCaja(CajaCREATE dto)
        {
            var caja = new Caja
            {
                Saldo = dto.Saldo
            };
            _context.Cajas.Add(caja);
            await _context.SaveChangesAsync();

            var movimiento = new MovimientoCaja
            {
                Tipo = TipodeMovimiento.Ingreso,
                Concepto = $"Inicialización de saldo en caja {caja.Saldo}",
                Monto = caja.Saldo,
                Fecha = DateTime.Now,
                CajaID = caja.CajaID,
            };
            _context.MovimientosCaja.Add(movimiento);
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
