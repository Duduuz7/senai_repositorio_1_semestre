// Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.


Console.WriteLine($"Insira o dia do seu aniversário: ");
int dia = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Insira o mes do seu aniversário (em número): ");
int mes = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Insira o ano do seu aniversário: ");
int ano = int.Parse(Console.ReadLine()!);


if (dia > 31 && dia < 1)
{
    Console.WriteLine($"Dia inválido !");
}

else if (mes > 12 && mes < 1)
{
    Console.WriteLine($"Mês inválido !");
}

else if (ano > 2013 && ano < 1000)
{
    Console.WriteLine($"Ano inválido !");   
}

else
{
    Console.WriteLine($"Data válida !");
}

