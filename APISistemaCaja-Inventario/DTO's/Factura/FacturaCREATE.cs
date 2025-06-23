namespace APISistemaCaja_Inventario.DTO_s.Factura
{
    // DTO para crear una factura con una lista de productos
    public class FacturaCREATE
    {
        public DateTime Fecha { get; set; } = DateTime.Now;
        public List<DetalleFacturaCREATE> Detalles {  get; set; }
    }
}
