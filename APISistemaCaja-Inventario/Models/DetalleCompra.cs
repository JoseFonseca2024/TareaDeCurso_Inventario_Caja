﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APISistemaCaja_Inventario.Models
{
    public class DetalleCompra
    {
        [Key]
        public int DetalleCompraID { get; set; }
        public int CompraID { get; set; }
        [ForeignKey("CompraID")]
        public Compra Compra { get; set; }

        [Required]
        public int ProductoID { get; set; }
        [ForeignKey("ProductoID")]
        public Producto Producto { get; set; }

        [Required]
        public int Cantidad { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CostoUnitario { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal IVA_Acreditable_Unitario { get; set; }
        public decimal Subtotal => CostoUnitario * Cantidad;
        public decimal IVATotal => IVA_Acreditable_Unitario * Cantidad;
        public decimal Total => (CostoUnitario + IVA_Acreditable_Unitario) * Cantidad;
    }
}