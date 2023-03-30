// As maçãs custam R$ 0,30 cada se forem compradas    menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor    total    da compra.


Console.WriteLine($"Digite quantas macas voce comprou: ");

int maca = int.Parse (Console.ReadLine()!);

if (maca >= 12)
{
   float valor1 = (maca * 0.25f);
   Console.WriteLine($"O total da compra foi: {valor1}");
}
else 
{
    float valor2 = (maca * 0.30f);
    Console.WriteLine($"O total da compra foi: {valor2}");
}