// Faça um programa que leia três números e mostre o maior e o menor deles.

Console.WriteLine($"Insira o primeiro número: ");
float primeiro = float.Parse (Console.ReadLine()!);

Console.WriteLine($"Insira o segundo número: ");
float segundo = float.Parse (Console.ReadLine()!);

Console.WriteLine($"Insira o terceiro número: ");
float terceiro = float.Parse (Console.ReadLine()!);

List<float> maiorMenor = new List<float> {primeiro, segundo, terceiro};

Console.WriteLine($"O maior número é o: {maiorMenor.Max()}");
Console.WriteLine($"O menor número é o: {maiorMenor.Min()}");




