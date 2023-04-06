// 1. Faça um programa que peça uma nota, ENTRE zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido

bool notaCerta = false;

while (notaCerta == true)
{
    Console.WriteLine($"Informe sua nota: ");
    float nota = float.Parse(Console.ReadLine()!);

    if (nota < 9 && nota > 0)
    {
        notaCerta = true;
        Console.WriteLine($"Sua nota é válida !");
    }
    else
    {
        Console.WriteLine($"Nota inválida, tente novamente !");
        
    }
    
}