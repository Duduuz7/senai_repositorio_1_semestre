using Microsoft.EntityFrameworkCore;
using projeto_gamer_backendmvc.Models;

namespace projeto_gamer_backendmvc.infra
{
    public class Context : DbContext
    {
        //classe responsável por configuracoes que vamos estabelecer com banco de dados, contem a string de conexao, conecta o projeto com o banco de dados

        public Context()
        {
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("DataSource = NOTE01-S15; initial catalog = gamer; Integrated Security = true; TrustServerCertificate = true;");
            }
        }

        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<Equipe> Equipe { get; set; }
        
    }
}