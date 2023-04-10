// 6. Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.

// Exemplo: tabuada do 1, tabuada do 2, etc...
// Dica: utilize um laço dentro do outro.


for (int x = 1; x < 10; x++)
{

    Console.WriteLine($"Tabuada do {x}");
    
    for (int y = 1; y < 10; y++)
    {

        Console.WriteLine($"{x} x {y} = {x * y}");

    }
}