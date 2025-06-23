namespace APISistemaCaja_Inventario.DTO_s.Factura
{
    // DTO para representar los detalles leídos de una factura
    public class FacturaDETALLE
    {
        public int DetalleFacturaID { get; set; }

        public int  ProductoID { get; set; }

        public string NombreProducto { get; set; }
                
        public int Cantidad {  get; set; }

        public decimal PrecioconIVA { get; set; }

        public decimal Total {  get; set; }

    }
}
