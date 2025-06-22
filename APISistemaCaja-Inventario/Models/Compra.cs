using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APISistemaCaja_Inventario.Models
{
    public class Compra
    {
        [Key]
        public int CompraID { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        [Column(TypeName = "decimal(7,2)")]
        public decimal Subtotal { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal IVA { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal Total { get; set; }
        public List<DetalleCompra> Detalles { get; set; } = new();
    }
}