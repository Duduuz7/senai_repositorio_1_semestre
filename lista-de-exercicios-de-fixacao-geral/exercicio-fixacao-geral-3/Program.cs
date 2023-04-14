// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%
// Dica: utilize if / else if / else

using System.Globalization;

Console.WriteLine($"Insira o nome do produto: ");
string nomeProduto = Console.ReadLine()!;

Console.WriteLine($"Insira a quantidade adquirida: ");
int quantidade = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Insira o preço do produto: ");
float preco = float.Parse(Console.ReadLine()!);

float total = quantidade * preco;
float resposta;
float totalDesconto;

if (quantidade <= 5)
{
    resposta = total * 2 / 100;
    totalDesconto = total - resposta;
}
 
 else if (quantidade > 5 && quantidade <= 10)
 {
    resposta = total * 3 / 100;
    totalDesconto = total - resposta;
 }

 else 
 {
    resposta = total * 5 / 100;
    totalDesconto = total - resposta;
 }

Console.WriteLine($"O valor total é de {total.ToString("C", new CultureInfo("pt-BR"))} e o total a pagar é de {totalDesconto.ToString("C", new CultureInfo("pt-BR"))}");


