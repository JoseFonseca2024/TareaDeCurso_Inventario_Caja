using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APISistemaCaja_Inventario.DTO_s.Caja
{
    public class CajaDTO
    {
        [Key]
        public int CajaID { get; set; }
        public decimal Saldo { get; set; }
    }
}
