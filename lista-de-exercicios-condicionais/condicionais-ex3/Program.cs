Console.WriteLine($"Informe o primeiro lado do triangulo: ");

float lado1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o segundo lado do triangulo: ");

float lado2 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o terceiro lado do triangulo: ");

float lado3 = float.Parse(Console.ReadLine()!);


if (lado1 == lado2 && lado2 ==lado3 && lado1 == lado3)
{
    Console.WriteLine($"Este triangulo e um triangulo equilatero !");    
}
else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
{
    Console.WriteLine($"Este triangulo e um triangulo escaleno !");    
}

else 
{
    Console.WriteLine($"Este triangulo e um triangulo isosceles !");
}
