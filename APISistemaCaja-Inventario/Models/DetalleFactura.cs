using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APISistemaCaja_Inventario.Models
{
    public class DetalleFactura
    {
        [Key]
        public int DetalleFacturaID { get; set; }

        public int FacturaID { get; set; }

        [ForeignKey("FacturaID")]
        public Factura Factura { get; set; }

        public int ProductoID { get; set; }

        [ForeignKey("ProductoID")]


        public Producto Producto { get; set; }

        public int Cantidad { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioconIVA { get; set; }

        [NotMapped]
        public decimal Total => Cantidad * PrecioconIVA;
    }
}