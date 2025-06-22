namespace APISistemaCaja_Inventario.DTO_s.Compra
{
    public class CompraREAD
    {
        public int CompraID { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;

        public decimal Subtotal { get; set; }

        public decimal IVA { get; set; }

        public decimal Total { get; set; }

        public List<DetalleCompraREAD> Detalles { get; set; } = new List<DetalleCompraREAD>();
    }
}
