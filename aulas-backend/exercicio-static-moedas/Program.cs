using exercicio_static_moedas;
using System.Globalization;

Console.WriteLine($"Bem vindo ao nosso conversor de moedas, pressione 'Enter' para prosseguir ao menu");
Console.ReadLine();

check:
Console.WriteLine(@$"

=========================================
   Qual conversão você deseja fazer ?

        [1] - Real para dólar 
        [2] - Dólar para real 
        [0] - Sair
       
      ");
string respostaMenu = Console.ReadLine()!;


switch (respostaMenu)
{
    case "1":
        float resultado1 = CoversorMoeda.RealParaDolar(CoversorMoeda.valor);
        Console.WriteLine($"");
        Console.WriteLine($"O valor equivalente em dólar é de: {resultado1.ToString("C", new CultureInfo("en-US"))}");
        goto check;
    case "2":
        float resultado2 = CoversorMoeda.DolarParaReal(CoversorMoeda.valor);
        Console.WriteLine($"");
        Console.WriteLine($"O valor equivalente em real é de: {resultado2.ToString("C", new CultureInfo("pt-BR"))}");
        goto check;
    case "0":
        Console.WriteLine($"Obrigado por utilizar o nosso conversor de moedas");
        break;
    default:
        Console.WriteLine($"Opção inválida, tente novamente !!!");
        goto check;
}