using System;
using System.ComponentModel.DataAnnotations;

namespace EpucGames.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [Display(Name ="Nome")]
        public string NomeCliente { get; set; }
        [Display(Name = "Data de Nascimento")][DataType(DataType.Date)]
        public DateTime DataNascimentoCliente { get; set; }

        [Display(Name = "E-mail")]
        public string EmailCliente { get; set; }

        [Display(Name = "Endereço")]
        public Endereco EnderecoCliente { get; set; }



    }
}
