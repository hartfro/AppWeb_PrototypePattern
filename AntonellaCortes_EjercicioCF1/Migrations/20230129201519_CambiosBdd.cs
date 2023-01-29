using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AntonellaCortes_EjercicioCF1.Migrations
{
    public partial class CambiosBdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HideRevenue",
                table: "Burger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPrivate",
                table: "Burger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Revenue",
                table: "Burger",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HideRevenue",
                table: "Burger");

            migrationBuilder.DropColumn(
                name: "IsPrivate",
                table: "Burger");

            migrationBuilder.DropColumn(
                name: "Revenue",
                table: "Burger");
        }
    }
}
