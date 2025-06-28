using System.ComponentModel.DataAnnotations.Schema;

namespace BosquejoProyecto1.DTO_s
{
    public class CajaCREATE
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal Saldo { get; set; }
    }
}
