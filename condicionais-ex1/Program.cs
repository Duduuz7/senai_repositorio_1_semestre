Console.WriteLine($"Informe seu salario: ");

float salario = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o total gasto: ");

float gasto = float.Parse(Console.ReadLine()!);


if (gasto > salario)
{
    Console.WriteLine($"Orcamento estourado !");    
}
else
{
    Console.WriteLine($"Gastos dentro do orcamento !");    
}
