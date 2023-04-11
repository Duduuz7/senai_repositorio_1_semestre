// int[] idade = new int[5];
// string[] nome = new string[5];

// for (int i = 0; i < 5; i++)
// {

//     Console.WriteLine($"Digite seu nome: ");
//     nome[i] = Console.ReadLine()!;

//     Console.WriteLine($"Digite sua idade: ");
//     idade[i] = int.Parse(Console.ReadLine()!);

// }

// for (int i = 0; i < 5; i++)
// {
//     Console.ForegroundColor = ConsoleColor.Blue;
//     Console.WriteLine($"{i + 1}) nome: {nome[i]}");
//     Console.ResetColor();
//     Console.ForegroundColor = ConsoleColor.Green;
//     Console.WriteLine($"idade: {idade[i]} anos");
//     Console.ResetColor();
// }

int[] numero = new int[6];

for (int i = 0; i < 6; i++)
{

    Console.WriteLine($"Digite o número desejado: ");
    numero[i] = int.Parse(Console.ReadLine()!);
}

for (int i = 0; i < 6; i++)
{
    if (numero[i] % 2 == 0) 
    {
        Console.WriteLine($"O {numero[i]} é par!");
    }
    else
    {
        Console.WriteLine($"O {numero[i]} é impar!");
    }
}

