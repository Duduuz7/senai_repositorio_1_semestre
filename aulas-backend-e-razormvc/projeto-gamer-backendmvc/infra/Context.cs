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
                //string de conexao, conecta o projeto com o banco de dados

                optionsBuilder.UseSqlServer("Data Source = NOTE01-S15; initial catalog = gamer; User Id=sa; pwd=Senai@134; TrustServerCertificate = true;");
            }
        }

        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<Equipe> Equipe { get; set; }
        
    }
}