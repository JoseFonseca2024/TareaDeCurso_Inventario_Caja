using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BosquejoProyecto1.DTO_s
{
    public class CajaCREATE
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal Saldo { get; set; }
    }
}
