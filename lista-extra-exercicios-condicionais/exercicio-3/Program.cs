// Escreva um programa que pergunte o raio de uma circunferência, e sem seguida mostre o diâmetro, comprimento e área da circunferência.

Console.WriteLine($"Escreva o raio da circunferência: ");
float raio = float.Parse(Console.ReadLine()!);

double diametro = (raio * 2);

double comprimento = (2 * Math.PI * raio);

double area = (Math.PI * Math.Pow(raio, 2));

Console.WriteLine($"O diametro da circunferencia é de: {diametro}");
Console.WriteLine($"O comprimento da circunferencia é de: {comprimento}");
Console.WriteLine($"A área da circunferencia é de: {area}");


