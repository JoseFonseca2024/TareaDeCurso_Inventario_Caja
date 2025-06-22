using System.ComponentModel.DataAnnotations.Schema;
namespace APISistemaCaja_Inventario.DTO_s.Caja
{
    public class CajaCREATE
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal Saldo { get; set; }
    }
}
