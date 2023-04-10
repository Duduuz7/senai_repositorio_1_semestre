//5. Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:

// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.

// char sexo;

// float idade = 0;
// float peso = 0;

int totalHomem = 0;
int totalMulher = 0;

float mediaHomem = 0;
float mediaMulher = 0;


for (int cont = 1; cont <= 3; cont++)
{
    Console.WriteLine(@$"
Qual seu sexo ?
(m) - Masculino
(f) - Feminino
");

    char sexo = char.Parse(Console.ReadLine()!);
    while (sexo != 'f' && sexo != 'm')
    {
        Console.WriteLine($"Erro. Digite novamente: ");
        sexo = char.Parse(Console.ReadLine()!);
    }

    if (sexo == 'm')
    {
        totalHomem++;
    }
    else
    {
        totalMulher++;
    }



    Console.WriteLine($"Qual sua idade ?");
    int idade = int.Parse(Console.ReadLine()!);

    while (idade < 0)
    {
        Console.WriteLine($"Erro. Digite novamente: ");
        idade = int.Parse(Console.ReadLine()!);
    }

    if (sexo == 'm')
    {
        mediaHomem += idade;
    }
    else
    {
        mediaMulher += idade;
    }




    Console.WriteLine($"Qual seu peso ?");
    float peso = float.Parse(Console.ReadLine()!);

    while (peso < 0)
    {
        Console.WriteLine($"Erro. Digite novamente: ");
        peso = float.Parse(Console.ReadLine()!);
    }

}

Console.WriteLine($"Total de homens é igual a: {totalHomem}");
Console.WriteLine($"Total de mulheres é igual a: {totalMulher}");
Console.WriteLine($"A média de idade das mulheres é igual a: {mediaMulher / totalMulher}");
Console.WriteLine($"A média de idade dos homens é igual a: {mediaHomem / totalHomem}");
