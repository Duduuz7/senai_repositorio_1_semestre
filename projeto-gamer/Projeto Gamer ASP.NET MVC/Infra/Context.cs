using Microsoft.EntityFrameworkCore;
using Projeto_Gamer_ASP.NET_MVC.Models;

// Classe responsável por fazer a conexão com o banco de dados
// Ela quem requisita informações ao banco de dados e retorna ao projeto

namespace Projeto_Gamer_ASP.NET_MVC.Infra
{
    public class Context : DbContext
    {
        public Context() {}

        public Context(DbContextOptions<Context> options) : base(options) {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer("Data Source = NOTE02-S14; initial catalog = gamerFullStack; User Id = sa; pwd = Senai@134; TrustServerCertificate = true");
            }
        }

        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<Equipe> Equipe { get; set; }
    }
}