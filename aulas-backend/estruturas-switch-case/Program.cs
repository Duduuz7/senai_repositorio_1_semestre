Console.WriteLine($"Informe o número correspondente ao dia da semana: ");
int diaSemana = int.Parse(Console.ReadLine()!);

switch (diaSemana)
{

    case 1:
        Console.WriteLine($"Hoje é Domingo !");
        break;
        
    case 2:
        Console.WriteLine($"Hoje é Segunda !");
        break;

    case 3:
        Console.WriteLine($"Hoje é Terça !");
        break;

    case 4:
        Console.WriteLine($"Hoje é Quarta !");
        break;

    case 5:
        Console.WriteLine($"Hoje é Quinta !");
        break;

    case 6:
        Console.WriteLine($"Hoje é Sexta !");
        break;

    case 7:
        Console.WriteLine($"Hoje é Sábado !");
        break;
        
}
