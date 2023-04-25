// Nesta aula vamos fazer um pequeno sistema de cadastro de alunos, em um projeto de console no VsCode.

// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.

// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

// Acrescente o que achar necessário.

using atividade_alunos;

Alunos a1 = new Alunos();

Console.WriteLine($"Bem vindo ao nosso sistema de cadastro de alunos !!!");
Console.WriteLine($"");

Console.WriteLine($"Insira o nome do Aluno: ");
a1.Nome = Console.ReadLine()!;
Console.WriteLine($"Insira o curso do Aluno: ");
a1.Curso = Console.ReadLine()!;
Console.WriteLine($"Insira a idade do Aluno: ");
a1.Idade = Console.ReadLine()!;
Console.WriteLine($"Insira o RG do Aluno: ");
a1.Rg = Console.ReadLine()!;

check:

Console.WriteLine($"O aluno é bolsista ? (utilize 'S' para sim e 'N' para não) ");
string bolsaS = Console.ReadLine()!.ToUpper();

if (bolsaS == "S")
{
    a1.Bolsa = true;
}
else if (bolsaS == "N")
{
    a1.Bolsa = false;
}
else
{
    Console.WriteLine($"Opção inválida, tente novamente!");
    goto check;
}

Console.WriteLine($"Insira a média final do aluno: ");
a1.MediaFinal = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Insira o valor bruto da mensalidade: ");
a1.ValorMensal = float.Parse(Console.ReadLine()!);

Console.WriteLine($"O cadastro do aluno foi realizado com sucesso, pressione 'Enter' para prosseguir ao menu!");
string prosseguir = Console.ReadLine()!;

bool menuResposta = false;
menu:
do
{

    Console.Clear();
    Console.WriteLine(@$"

----------------------------
| Bem vindo ao nosso menu! |
|                          |
|  Escolha uma das opções: |   
|                          |
|   1. Ver média final     | 
|   2. Ver valor total     |
|       mensalidade        |
|   0.     Sair            |
----------------------------

");

    string repostaMenu = Console.ReadLine()!;

    if (repostaMenu == "1")
    {
        a1.MostrarMedia();
        Console.WriteLine($"");
        Console.WriteLine($"Pressione 'Enter' para voltar ao menu.");
        Console.ReadLine();
        goto menu;

    }

    else if (repostaMenu == "2")
    {
        Console.WriteLine($"O valor total da mensalidade é de: {a1.MostrarMensalidade()}");
        
    }

    else if (repostaMenu == "0")
    {
        Console.WriteLine($"Obrigado por acessar nosso sistema, volte sempre!!!");
    }

    else
    {
        Console.WriteLine($"Opção inválida, escolha uma opção válida!");
        repostaMenu = Console.ReadLine()!;
    }


} while (menuResposta == true);


// If e Else da bolsa usando operador ternario, a1.Bolsa = bolsaS == "S" ? true : false;
