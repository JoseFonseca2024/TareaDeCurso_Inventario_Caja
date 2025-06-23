namespace APISistemaCaja_Inventario.DTO_s.Factura
{
    // DTO para registrar un producto dentro de una nueva factura
    public class DetalleFacturaCREATE
    {
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }
    }
}
