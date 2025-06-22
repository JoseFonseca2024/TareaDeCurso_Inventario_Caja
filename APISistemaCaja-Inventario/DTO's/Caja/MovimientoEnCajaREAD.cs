using APISistemaCaja_Inventario.Models;
namespace APISistemaCaja_Inventario.DTO_s.Caja
{
    public class MovimientoEnCajaREAD
    {
        public int MovimientoID { get; set; }
        public TipodeMovimiento Tipo { get; set; }
        public decimal Monto { get; set; }
        public string Concepto { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
