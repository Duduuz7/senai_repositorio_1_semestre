// 3. Faça um programa que receba um número inteiro e mostre a sua tabuada.



Console.WriteLine($"Digite o numero desejado: ");
int numero = int.Parse(Console.ReadLine()!);

for (int y = 0; y < 11; y++)
{
    Console.WriteLine($"{numero} x {y} = {numero * y}");
}


