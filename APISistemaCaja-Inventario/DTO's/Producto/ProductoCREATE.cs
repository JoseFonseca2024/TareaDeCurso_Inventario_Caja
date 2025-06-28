namespace APISistemaCaja_Inventario.DTO_s.Producto
{
    public class ProductoCREATE
    {
        public string NombreProducto { get; set; }
        public decimal CostoProducto { get; set; }
        public decimal PrecioConIVA { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaIngreso { get; set; } = DateTime.Now;
    }
}
