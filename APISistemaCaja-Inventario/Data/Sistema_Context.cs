using APISistemaCaja_Inventario.Models;
using Microsoft.EntityFrameworkCore;

namespace APISistemaCaja_Inventario.Data
{
    public class Sistema_Context : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Caja> Cajas { get; set; }
        public DbSet<MovimientoCaja> MovimientosCaja { get; set; }
        public DbSet<Compra> Compras { get; set; }

        public Sistema_Context(DbContextOptions<Sistema_Context> options) : base(options) { }
    }
}
