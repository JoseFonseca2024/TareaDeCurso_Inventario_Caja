namespace APISistemaCaja_Inventario.DTO_s.Compra
{
    public class CompraCREATE
    {
        public DateTime Fecha { get; set; }
        public List<DetalleCompraCREATE> Detalles { get; set; }
    }
}
