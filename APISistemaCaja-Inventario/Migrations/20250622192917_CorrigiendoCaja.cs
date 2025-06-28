using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APISistemaCaja_Inventario.Migrations
{
    /// <inheritdoc />
    public partial class CorrigiendoCaja : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaApertura",
                table: "Cajas");

            migrationBuilder.DropColumn(
                name: "FechaCierre",
                table: "Cajas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaApertura",
                table: "Cajas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCierre",
                table: "Cajas",
                type: "datetime2",
                nullable: true);
        }
    }
}
