using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APISistemaCaja_Inventario.Models
{
    public class MovimientoCaja
    {
        [Key]
        public int MovimientoID { get; set; }

        [Required]
        public TipodeMovimiento Tipo { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Monto { get; set; }

        [Required]
        public string Concepto { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public int CajaID { get; set; }

        [ForeignKey("CajaID")]
        public Caja Caja { get; set; }
    }
}