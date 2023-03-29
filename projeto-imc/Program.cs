// PROGAMA IMC 

// Faca um programa que calcule o imc de uma pessoa recebendo os dados no console, ao final imprima o resultado no console

Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine(@$"
-----------------
| Programa para |
| calcular IMC  |
-----------------
");

Console.ResetColor();

Console.BackgroundColor = ConsoleColor.Green;

Console.WriteLine($"Informe o nome do paciente: ");

string nome = Console.ReadLine();

Console.WriteLine($"Informe o peso atual do paciente: ");

float peso = float.Parse(Console.ReadLine());


Console.WriteLine($"Informe a altura do paciente: ");

float altura = float.Parse(Console.ReadLine());


float imc = peso / ((float)Math.Pow(altura,2));

Console.WriteLine($"O paciente {nome} tem imc igual a : ");

Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGreen;

Console.WriteLine($"Obrigado por utilizar nosso sistema !");

Console.ResetColor();
