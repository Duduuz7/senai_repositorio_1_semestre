// 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

// contains true false, dentro do if se for true achei se for false nao achei

//declarando um array
string[] nomes = new string[3];

bool nomeEncontrado = false;

for (var i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Informe o {i + 1}º nome: ");
    nomes[i] = Console.ReadLine()!;    
}

Console.WriteLine($"Informe o nome a ser buscado: ");
string nomeBuscado = Console.ReadLine()!;

//processamento
foreach (string nome in nomes)
{
    if (nome == nomeBuscado)
    {
        nomeEncontrado = true;
        break;
    }
}

//saída - exibir
if (nomeEncontrado == true)
{
    Console.WriteLine($"ACHEI");    
}
else
{
    Console.WriteLine($"NÃO ACHEI");    
}

string resultadoBusca = nomeEncontrado == true ? "ACHEI" : "Não ACHEI";
Console.WriteLine(resultadoBusca);

Console.WriteLine(nomeEncontrado ? "ACHEI" : "Não ACHEI");






// if(nomes.Contains(resposta) == true)
// {
//     Console.WriteLine($"Achei !");
// }
// else{
//     Console.WriteLine($"Não achei !");
// }
