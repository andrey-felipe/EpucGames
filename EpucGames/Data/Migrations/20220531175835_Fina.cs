using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EpucGames.Data.Migrations
{
    public partial class Fina : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VendaCliente",
                columns: table => new
                {
                    IdVenda = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataVenda = table.Column<DateTime>(nullable: false),
                    ValorVenda = table.Column<decimal>(nullable: false),
                    ProdutoVendaIdProduto = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaCliente", x => x.IdVenda);
                    table.ForeignKey(
                        name: "FK_VendaCliente_Produto_ProdutoVendaIdProduto",
                        column: x => x.ProdutoVendaIdProduto,
                        principalTable: "Produto",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VendaCliente_ProdutoVendaIdProduto",
                table: "VendaCliente",
                column: "ProdutoVendaIdProduto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendaCliente");
        }
    }
}
