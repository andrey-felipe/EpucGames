using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using EpucGames.Models;

namespace EpucGames.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EpucGames.Models.Cliente> Cliente { get; set; }
        public DbSet<EpucGames.Models.Produto> Produto { get; set; }
        public DbSet<EpucGames.Models.Fornecedor> Fornecedor { get; set; }
        public DbSet<EpucGames.Models.Endereco> Endereco { get; set; }
        public DbSet<EpucGames.Models.CompraFornecedor> CompraFornecedor { get; set; }
        public DbSet<EpucGames.Models.VendaCliente> VendaCliente { get; set; }
    }
}
