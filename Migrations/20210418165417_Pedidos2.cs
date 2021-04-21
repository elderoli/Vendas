using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendas.Migrations
{
    public partial class Pedidos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "mesa",
                table: "Pedido",
                newName: "Mesa");

            migrationBuilder.AddColumn<string>(
                name: "Cliente",
                table: "Pedido",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cliente",
                table: "Pedido");

            migrationBuilder.RenameColumn(
                name: "Mesa",
                table: "Pedido",
                newName: "mesa");
        }
    }
}
