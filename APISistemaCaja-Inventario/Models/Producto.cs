using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APISistemaCaja_Inventario.Models
{
    public class Producto
    {
        [Key]
        public int ProductoID { get; set; }

        [Required, MaxLength(50)]
        public string NombreProducto { get; set; }

        [Required, Column(TypeName = "decimal(7,2)")]
        public decimal CostoProducto { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal PrecioconIVA { get; set; }

        [Required, Range(0, int.MaxValue)]
        public int Cantidad { get; set; }

        public DateTime FechaIngreso { get; set; } = DateTime.Now;
    }
}