using System.ComponentModel.DataAnnotations;

namespace EpucGames.Models
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }

       [Display(Name ="Nome do produto")]
        public string NomeProduto { get; set; }
        [Display(Name ="Preço do produto")]
        public decimal PrecoProduto { get; set; }
        [Display(Name = "Caracteristicas do produto")]
        public string CaracteristicasProduto { get; set; }
        public Fornecedor FornecedorProduto { get; set; }
    }
}
