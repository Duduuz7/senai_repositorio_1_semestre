using System.ComponentModel.DataAnnotations;

namespace projeto_gamer_backendmvc.Models
{
    public class Equipe
    {
        [Key] //notacao que diz que é uma chave primária, funciona para a primeira abaixo dela
        public int IdEquipe { get; set; }
        public string? Nome { get; set; }
        public string? Imagem { get; set; }

        public ICollection<Jogador>? Jogador { get; set; }
    }
}