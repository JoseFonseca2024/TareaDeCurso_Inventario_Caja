namespace BosquejoProyecto1.DTO_s.Producto
{
    public class ProductoREAD
    {
        public int ProductoID { get; set; }
        public string NombreProducto { get; set; }
        public decimal CostoProducto { get; set; }
        public decimal PrecioConIVA { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaIngreso { get; set; } = DateTime.Now;
    }
}
