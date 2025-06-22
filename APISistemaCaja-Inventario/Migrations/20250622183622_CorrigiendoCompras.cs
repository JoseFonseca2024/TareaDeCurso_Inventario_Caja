using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APISistemaCaja_Inventario.Migrations
{
    /// <inheritdoc />
    public partial class CorrigiendoCompras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrecioUnitario",
                table: "DetalleCompra",
                newName: "IVA_Acreditable_Unitario");

            migrationBuilder.AddColumn<decimal>(
                name: "CostoUnitario",
                table: "DetalleCompra",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CostoUnitario",
                table: "DetalleCompra");

            migrationBuilder.RenameColumn(
                name: "IVA_Acreditable_Unitario",
                table: "DetalleCompra",
                newName: "PrecioUnitario");
        }
    }
}
