using System.ComponentModel.DataAnnotations;

namespace EpucGames.Models
{
    public class Fornecedor
    {
        [Key]
        public int IdFornecedor { get; set; }
        public string NomeFornecedor { get; set; }
        public string TelefoneFornecedor { get; set; }
        public Endereco EnderecoFornecedor { get; set; }
        public decimal ComissaoFornecedor { get; set; }
    }
}
