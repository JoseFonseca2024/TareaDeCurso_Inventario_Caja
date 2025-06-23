using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APISistemaCaja_Inventario.Models
{
    // Representa una factura general con totales y una lista de productos vendidos
    public class Factura
    {
        [Key]
        public int FacturaID { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(7,2)")]
        public decimal Subtotal { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal IVA { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal Total { get; set; }

        public List<DetalleFactura> Detalles { get; set; } = new();
    }
}
