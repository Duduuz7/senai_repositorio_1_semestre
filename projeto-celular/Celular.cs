namespace projeto_celular
{
    public class Celular
    {
        //PROPRIEDADES
        public string Cor;
        public string Modelo;
        public string Tamanho;
        public bool Ligado;

        //FUNCOES 

        public void Ligar()
        {
            Console.WriteLine($"Ligando o aparelho...");            
        }
          public void Desligar()
        {
            Console.WriteLine($"Desligando o aparelho...");
        }
          public void FazerLigacao()
        {
            Console.WriteLine($"Fazendo ligação...");
            Console.WriteLine($"Ligação feita, voltando ao menu...");
        }
          public void EnviarMensagem()
        {
            Console.WriteLine($"Enviando mensagem...");
            Console.WriteLine($"Mensagem enviada, voltando ao menu...");
        }
    }
}