namespace BosquejoProyecto1.DTO_s
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
