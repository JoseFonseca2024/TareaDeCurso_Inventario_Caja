using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BosquejoProyecto1.DTO_s.Producto
{
    public class ProductoUPDATE
    {
            public string NombreProducto { get; set; }
            public decimal CostoProducto { get; set; }
            public decimal PrecioConIVA { get; set; }
            public int Cantidad { get; set; }
        
    }
}
