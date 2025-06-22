using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APISistemaCaja_Inventario.Models
{
    public class Caja
    {
        [Key]
        public int CajaID { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Saldo { get; set; }

        public List<MovimientoCaja> Movimientos { get; set; } = new List<MovimientoCaja>();
    }
}
