using Microsoft.EntityFrameworkCore.Migrations;

namespace EpucGames.Data.Migrations
{
    public partial class AddDemaisItens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompraFornecedor",
                columns: table => new
                {
                    IDCompraFornecedor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FornecedorCompraIdFornecedor = table.Column<int>(nullable: true),
                    ProdutoCompraFornecedorIdProduto = table.Column<int>(nullable: true),
                    QuantidadeCompraFornecedor = table.Column<int>(nullable: false),
                    ValorCompraFornecedor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompraFornecedor", x => x.IDCompraFornecedor);
                    table.ForeignKey(
                        name: "FK_CompraFornecedor_Fornecedor_FornecedorCompraIdFornecedor",
                        column: x => x.FornecedorCompraIdFornecedor,
                        principalTable: "Fornecedor",
                        principalColumn: "IdFornecedor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompraFornecedor_Produto_ProdutoCompraFornecedorIdProduto",
                        column: x => x.ProdutoCompraFornecedorIdProduto,
                        principalTable: "Produto",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompraFornecedor_FornecedorCompraIdFornecedor",
                table: "CompraFornecedor",
                column: "FornecedorCompraIdFornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_CompraFornecedor_ProdutoCompraFornecedorIdProduto",
                table: "CompraFornecedor",
                column: "ProdutoCompraFornecedorIdProduto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompraFornecedor");
        }
    }
}
