// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

Console.WriteLine($"Digite seu ano de nascimento: ");
int ano = int.Parse(Console.ReadLine()!);

int idade = DateTime.Now.Year - ano;

if (idade <= 16)
{
    Console.WriteLine($"Você ainda não pode votar esse ano !");
}

else 
{
    Console.WriteLine($"Você já pode votar !");
}

