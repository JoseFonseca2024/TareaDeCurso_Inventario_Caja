using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APISistemaCaja_Inventario.Models
{
    public class MovimientoCaja
    {
        [Key]
        public int MovimientoID { get; set; }

        public TipodeMovimiento Tipo { get; set; }

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