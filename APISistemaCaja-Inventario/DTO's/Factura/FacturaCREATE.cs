namespace APISistemaCaja_Inventario.DTO_s.Factura
{
    public class FacturaCREATE
    {
        public DateTime Fecha { get; set; } = DateTime.Now;
        public List<DetalleFacturaCREATE> Detalles { get; set; }
    }
}
