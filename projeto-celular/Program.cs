// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using projeto_celular;

Celular c1 = new Celular();

Console.WriteLine($"Qual a cor do seu aparelho ?");
c1.Cor = Console.ReadLine()!;
Console.WriteLine($"Qual o modelo do seu aparelho ?");
c1.Modelo = Console.ReadLine()!;
Console.WriteLine($"Qual o tamanho do seu aparelho ?");
c1.Tamanho = Console.ReadLine()!;

check:
Console.WriteLine($"O aparelho está ligado ? (Utilize 'S' para sim, e 'N' para não.)");
string respostaLigado = Console.ReadLine()!.ToUpper();

if (respostaLigado == "S")
{
    c1.Ligado = true;
    Console.WriteLine($"Pressione 'Enter' para prosseguir ao menu!");
    Console.ReadLine();
}
else if (respostaLigado == "N")
{
    c1.Ligado = false;
    Console.WriteLine($"Você precisa ligar o aparelho para prosseguir, pressione 'Enter' para ligar.");
    Console.ReadLine();
    c1.Ligar();
    Console.WriteLine($"Pressione 'Enter' novamente para prosseguir ao menu!");
    
    
    
}
else
{
    Console.WriteLine($"Resposta inválida, tente novamente");
    goto check;
}

menuVoltar:

    Console.WriteLine(@$"

----------------------------
|       Menu Celular       |
|                          |
|  Escolha uma das opções: |   
|                          |
|   1. Fazer ligação       | 
|   2. Enviar mensagem     |
|   3. Desligar o aparelho |
----------------------------

");

    string repostaMenu = Console.ReadLine()!;

    switch (repostaMenu)
    {
        case "1": 
        c1.FazerLigacao();
        goto menuVoltar;

        case "2": 
        c1.EnviarMensagem();
        goto menuVoltar;

        case "3":
        c1.Desligar();
        break;
        
        default:   
        Console.WriteLine($"Opção inválida, utilize uma das opções do menu!");
        goto menuVoltar;

    }





