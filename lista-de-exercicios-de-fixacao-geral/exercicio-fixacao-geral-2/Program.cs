// 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

using System.Globalization;

bool repetir = true;
char tipoCombustivel;
do
{
   Console.WriteLine(@$"

Qual tipo de combustível você deseja?

(a) para alcool

    ou

(g) gasolina
");
tipoCombustivel = char.Parse(Console.ReadLine());

if (tipoCombustivel == 'a')
{
    repetir = false;
    Console.WriteLine($"Você escolheu alcool.");
}

else if (tipoCombustivel == 'g')
{
    repetir = false;
    Console.WriteLine($"Você escolheu gasolina.");
} 

else
{
    Console.WriteLine($"Opção invalida, tente novamente!");
    repetir = true;    
}
} while (repetir);

Console.WriteLine($"Quantos litros você deseja?");
float litros = float.Parse(Console.ReadLine());

static float Abastecer(float litros, char tipoCombustivel)
{
    if (litros <= 20 && tipoCombustivel == 'a')
    {
        return litros * 4.90F - 4.90F * 3 / 100;
    }

    else if (litros > 20 && tipoCombustivel == 'a')
    {
        return litros * 4.90F - 4.90F * 5 / 100;
    }

    else if (litros <= 20 && tipoCombustivel == 'g')
    {
        return litros * 5.30F - 5.30F * 4 / 100;
    }

    else
    {
        return litros * 5.30F - 5.30F * 6 / 100;
    }
}

float resultado = Abastecer(litros, tipoCombustivel);

Console.WriteLine($"Você vai pagar {resultado.ToString("C", new CultureInfo("pt-BR"))} pelo combustível !");