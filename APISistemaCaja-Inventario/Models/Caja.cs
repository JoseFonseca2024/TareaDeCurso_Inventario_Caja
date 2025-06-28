using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APISistemaCaja_Inventario.Models
{
    public class Caja
    {
        [Key]
        public int CajaID { get; set; }

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal Saldo { get; set; }

        public List<MovimientoCaja> Movimientos { get; set; } = new List<MovimientoCaja>();
    }
}
