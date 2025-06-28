using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APISistemaCaja_Inventario.Models
{
    public class DetalleFactura
    {
        [Key]
        public int DetalleFacturaID { get; set; }

        public int FacturaID { get; set; }

        [ForeignKey("FacturaID")]
        public Factura Factura { get; set; }

        [Required]
        public int ProductoID { get; set; }

        [ForeignKey("ProductoID")]
        public Producto Producto { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioconIVA { get; set; }

        public decimal Total => Cantidad * PrecioconIVA;
    }
}