
using APISistemaCaja_Inventario.Data;
using APISistemaCaja_Inventario.DTO_s.Producto;
using APISistemaCaja_Inventario.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APISistemaCaja_Inventario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoesController : ControllerBase
    {
        private readonly Sistema_Context _context;

        public ProductoesController(Sistema_Context context)
        {
            _context = context;
        }

        // GET: api/Productoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductoREAD>>> GetProductos()
        {
            return await _context.Productos.Select(p => new ProductoREAD
            {
                ProductoID = p.ProductoID,
                NombreProducto = p.NombreProducto,
                CostoProducto = p.CostoProducto,
                PrecioConIVA = p.PrecioconIVA,
                Cantidad = p.Cantidad,
                FechaIngreso = p.FechaIngreso
            }).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductoREAD>> GetProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);

            if (producto == null)
            {
                return NotFound();
            }

            var dto = new ProductoREAD
            {
                ProductoID = producto.ProductoID,
                NombreProducto = producto.NombreProducto,
                CostoProducto = producto.CostoProducto,
                PrecioConIVA = producto.PrecioconIVA,
                Cantidad = producto.Cantidad,
                FechaIngreso = producto.FechaIngreso
            };

            return dto;
        }


        // PUT: api/Productoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducto(int id, ProductoUPDATE dto)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto == null) return NotFound();

            producto.NombreProducto = dto.NombreProducto;
            producto.CostoProducto = dto.CostoProducto;
            producto.PrecioconIVA = dto.PrecioConIVA;
            producto.Cantidad = dto.Cantidad;

            await _context.SaveChangesAsync();


            return NoContent();
        }

        // POST: api/Productoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult> PostProducto(ProductoCREATE dto)
        {
            var producto = new Producto
            {
                NombreProducto = dto.NombreProducto,
                CostoProducto = dto.CostoProducto,
                PrecioconIVA = dto.PrecioConIVA,
                Cantidad = dto.Cantidad,
                FechaIngreso = dto.FechaIngreso
            };

            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProductos), new { id = producto.ProductoID }, producto);
        }

        // DELETE: api/Productoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }

            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductoExists(int id)
        {
            return _context.Productos.Any(e => e.ProductoID == id);
        }
    }
}
