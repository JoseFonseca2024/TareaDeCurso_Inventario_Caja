using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public List<DetalleCompra> Detalles { get; set; } = new List<DetalleCompra>();
    }
}