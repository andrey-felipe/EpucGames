using System;
using System.ComponentModel.DataAnnotations;

namespace EpucGames.Models
{
    public class VendaCliente
    {
        [Key]
        public int IdVenda { get; set; }

        [Display(Name = "Data da venda")]
        [DataType(DataType.Date)]
        public DateTime DataVenda{ get; set; }

        [Display(Name = "Valor da venda")]
        public decimal ValorVenda { get; set; }

        public Produto ProdutoVenda { get; set;}


    }
}
