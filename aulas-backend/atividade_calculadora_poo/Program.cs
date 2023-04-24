// //Nesta aula vamos fazer um pequeno sistema de calculadora, em um projeto de console no VsCode.
// Vamos desenvolver um programa orientado a objeto que faça as 4 operações matemáticas.
// Crie uma classe Calculadora;
// Criar um método para cada uma das operações matemáticas(retornar float);
// Fazer o menu de opções;
// Solicitar a entrada de 2 números para o cálculo e exiba o resultado do cálculo no console.

using atividade_calculadora_poo;

calcular c1 = new calcular();

Console.WriteLine($"Digite o primeiro número: ");
c1.n1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o segundo número");
c1.n2 = int.Parse(Console.ReadLine()!);

    Console.WriteLine(@$"

Escolha uma das opções de conta abaixo:

    (1) - Subtração
    (2) - Soma
    (3) - Multiplicação
    (4) - Divisão

");

    int conta = int.Parse(Console.ReadLine()!);

    switch (conta)
    {
        case 1:
            float resultado = c1.Subtrair();
            Console.WriteLine($"O resultado é {resultado}");
            break;

        case 2:
             float resultado2 = c1.Somar();
            Console.WriteLine($"O resultado é {resultado2}");
            break;

        case 3:
             float resultado3 = c1.Multiplicar();
            Console.WriteLine($"O resultado é {resultado3}");
            break;

        case 4:
             float resultado4 = c1.Subtrair();
            Console.WriteLine($"O resultado é {resultado4}");
            break;
           
        default:
            Console.WriteLine($"Valor inválido!!!");
            break;
    }






