namespace BosquejoProyecto1.DTO_s
{
    public class FacturaCREATE
    {
        public DateTime Fecha { get; set; } = DateTime.Now;
        public List<DetalleFacturaCREATE> Detalles {  get; set; }
    }
}
