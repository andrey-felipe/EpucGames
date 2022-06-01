using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EpucGames.Models
{
    public class Endereco
    {
        [Key]
        public int IdEndereco { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Cliente Cliente { get; set; }
        [ForeignKey("Cliente")]
       public int ClientId { get; set; }


    }
}
