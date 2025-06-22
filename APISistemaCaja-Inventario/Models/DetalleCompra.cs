using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APISistemaCaja_Inventario.Models
{
    public class DetalleCompra
    {
        [Key]
        public int DetalleCompraID { get; set; }
        public int CompraID { get; set; }
        [ForeignKey("CompraID")]
        public Compra Compra { get; set; }

        public int ProductoID { get; set; }
        [ForeignKey("ProductoID")]
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioUnitario { get; set; }
        public decimal Total => Cantidad * PrecioUnitario;
    }
}