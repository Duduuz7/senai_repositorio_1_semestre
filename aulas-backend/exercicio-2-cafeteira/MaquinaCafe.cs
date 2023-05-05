namespace exercicio_2_cafeteira

{
    public class MaquinaCafe
    {
        public float acucarDisponivel { get; private set; } = 100;
        public float acucar { get; set; }
        public string semAcucar { get; private set; }

        public string respostaAcucarPadrao { get; set; }

        public bool validaçãoPedido { get; private set; } = true;

        public void FazerCafe(float acucarDisponivel)
        {
            if (acucarDisponivel > 0)
            {
                voltarAcucar:
                Console.WriteLine($"Quanto de açucar você deseja adicionar ao café?");
                acucar = float.Parse(Console.ReadLine()!);
                if (acucar > 0 && acucar < 100)
                {
                    Console.WriteLine($"Adicionameremos {acucar} gramas de açucar no seu café!");
                    Console.WriteLine($"Seu café está pronto !");
                    
                }

                else
                {
                    Console.WriteLine($"A quantidade de açucar desejada esta indisponivel, por favor tente novamente!");
                    goto voltarAcucar;
                }
            }

            else
            {
            cafecheck:
                Console.WriteLine(@$"
                O estoque de açucar acabou, gostaria de pedir um café sem açucar?

                (1) Café sem açucar
                (2) Cancelar pedido
                ");

                semAcucar = Console.ReadLine()!;
                switch (semAcucar)
                {
                    case "1":
                        Console.WriteLine($"Seu café sem açucar está pronto!");
                        break;
                    case "2":
                        Console.WriteLine($"Pedido cancelado...");
                        break;
                    default:
                        Console.WriteLine($"Por favor insira uma respostas válida");
                        goto cafecheck;
                }
            }
        }

        public void FazerCafe()
        {
            if (acucarDisponivel > 0)
            {
                do
                {
                    Console.WriteLine(@$"
                Será adicionado 10g de açucar no seu café!

                    tudo bem ou deseja cancelar o pedido?

                    [1] concluir pedido
                    [2] cancelar pedido
                ");

                    respostaAcucarPadrao = Console.ReadLine()!;


                    switch (respostaAcucarPadrao)
                    {
                        case "1":
                            validaçãoPedido = false;
                            Console.WriteLine($"Seu café está pronto !");
                            Console.Beep(1000, 1000);
                            break;
                        case "2":
                            validaçãoPedido = false;
                            Console.WriteLine($"Cancelando pedido..");
                            break;
                        default:
                            validaçãoPedido = true;
                            Console.WriteLine($"Por favor insira uma resposta válida!");
                            break;
                    }
                } while (validaçãoPedido);

            }
        }
    }
}