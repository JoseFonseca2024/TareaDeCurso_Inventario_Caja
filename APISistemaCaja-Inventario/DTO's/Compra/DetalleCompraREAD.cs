namespace APISistemaCaja_Inventario.DTO_s.Compra
{
    public class DetalleCompraREAD
    {
        public int DetalleCompraID { get; set; }
        public int ProductoID { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal IVAUnitario { get; set; }
        public decimal Total { get; set; }
    }
}
