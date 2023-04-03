// Calculadora


// Algoritmo

// 1. informar a operacao
// 2. informar o primeiro numero
// 3. informar o segundo numero
// 4. processar os dados
// 5. exibir o resultado

// Entrada

Console.WriteLine(@$"
---------------------------
| Programa de Calculadora |
|                         |
|   Infome a operação     |   
|                         |
|   (+) soma              | 
|   (-) subtração         |
|   (*) multiplicação     |
|   (/) divisão           |
---------------------------

");

char operacao = char.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o primeiro número: ");
double num1 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o segundo número: ");
double num2 = double.Parse(Console.ReadLine()!);

double resultado = 0;

// Processamento
// Saída

switch (operacao)
{
    case '+':

        resultado = num1 + num2;
        Console.WriteLine($"O resultado da conta é igual a: {resultado}");
        
        break;

    case '-':

        resultado = num1 - num2;
        Console.WriteLine($"O resultado da conta é igual a: {resultado}");

    break;

    case '*':

        resultado = num1 * num2;
        Console.WriteLine($"O resultado da conta é igual a: {resultado}");

    break;

    case '/':

        resultado = num1 / num2;
        Console.WriteLine($"O resultado da conta é igual a: {resultado}");

    break;

    default:

        Console.WriteLine($"Operação inválida, repita o processo!");
        
        break;
}
