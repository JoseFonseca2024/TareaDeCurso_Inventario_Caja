namespace APISistemaCaja_Inventario.DTO_s.Factura
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
