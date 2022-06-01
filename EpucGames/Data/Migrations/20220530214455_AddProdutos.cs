using Microsoft.EntityFrameworkCore.Migrations;

namespace EpucGames.Data.Migrations
{
    public partial class AddProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    IdFornecedor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFornecedor = table.Column<string>(nullable: true),
                    TelefoneFornecedor = table.Column<string>(nullable: true),
                    EnderecoFornecedorIdEndereco = table.Column<int>(nullable: true),
                    ComissaoFornecedor = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.IdFornecedor);
                    table.ForeignKey(
                        name: "FK_Fornecedor_Endereco_EnderecoFornecedorIdEndereco",
                        column: x => x.EnderecoFornecedorIdEndereco,
                        principalTable: "Endereco",
                        principalColumn: "IdEndereco",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    IdProduto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProduto = table.Column<string>(nullable: true),
                    PrecoProduto = table.Column<decimal>(nullable: false),
                    CaracteristicasProduto = table.Column<string>(nullable: true),
                    FornecedorProdutoIdFornecedor = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.IdProduto);
                    table.ForeignKey(
                        name: "FK_Produto_Fornecedor_FornecedorProdutoIdFornecedor",
                        column: x => x.FornecedorProdutoIdFornecedor,
                        principalTable: "Fornecedor",
                        principalColumn: "IdFornecedor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_EnderecoFornecedorIdEndereco",
                table: "Fornecedor",
                column: "EnderecoFornecedorIdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_FornecedorProdutoIdFornecedor",
                table: "Produto",
                column: "FornecedorProdutoIdFornecedor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Fornecedor");
        }
    }
}
