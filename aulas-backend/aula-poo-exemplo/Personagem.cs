namespace aula_poo_exemplo
{
    public class Personagem
    {
        //Atributos
        //NOME, IDADE, ARMADURA, IA

        public string nome;

        public int idade;

        public string armadura;

        public string ia;

        //Métodos
        //ATACAR, DEFENDER, RESTAURAR, ARMADURA

        public void Atacar()
        {
            Console.WriteLine($"O personagem atacou !!!");
        }

         public void Defender()
        {
            Console.WriteLine($"O personagem defendeu !!!");
        }
        
         public void RestaurarArmadura()
        {
            Console.WriteLine($"Armadura Restaurada !!!");
        }
        
    }
}