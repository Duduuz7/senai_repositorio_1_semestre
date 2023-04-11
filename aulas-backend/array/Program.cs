string[]carros = new string[3];

for (int i = 0; i < 3; i++)
{
    //bloco de código a se executado
    Console.WriteLine($"Digite o nome do {i + 1}º carro: ");
    carros[i] = Console.ReadLine()!;
    
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"O {i + 1}º carro é: {carros[i]}");
    
}