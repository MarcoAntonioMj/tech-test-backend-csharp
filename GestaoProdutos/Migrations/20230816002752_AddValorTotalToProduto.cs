using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoProdutos.Migrations
{
    /// <inheritdoc />
    public partial class AddValorTotalToProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ValorTotal",
                table: "produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorTotal",
                table: "produtos");
        }
    }
}
