using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BosquejoProyecto1.Class
{
    public class DetalleCompraTemp
    {
        public int ProductoID { get; set; } // 0 = aún no existe en BD
        public string NombreProducto { get; set; } = string.Empty;
        public decimal CostoUnitario { get; set; }
        public int Cantidad { get; set; }
        public bool EsNuevo => ProductoID == 0;

        public decimal IVA => Math.Round(CostoUnitario * 0.15m, 2);
        public decimal Subtotal => CostoUnitario * Cantidad;
        public decimal Total => (CostoUnitario + IVA) * Cantidad;
    }
}
