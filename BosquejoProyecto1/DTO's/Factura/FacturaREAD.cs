namespace BosquejoProyecto1.DTO_s
{
    public class FacturaREAD
    {
        public int FacturaID { get; set; }
        public decimal Subtotal { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public List<FacturaDETALLE> Detalles { get; set; }
    }
}
