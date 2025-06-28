using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BosquejoProyecto1.DTO_s
{
    public class CajaDTO
    {
        [Key]
        public int CajaID { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Saldo { get; set; }
    }
}
