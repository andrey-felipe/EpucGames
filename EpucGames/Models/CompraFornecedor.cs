using System.ComponentModel.DataAnnotations;

namespace EpucGames.Models
{
    public class CompraFornecedor
    {
        [Key]
        public int IDCompraFornecedor { get; set; }

        public Fornecedor FornecedorCompra { get; set; }
        public Produto  ProdutoCompraFornecedor { get; set; }

        public int QuantidadeCompraFornecedor { get; set; }

        public int ValorCompraFornecedor { get; set; }
    }
}
