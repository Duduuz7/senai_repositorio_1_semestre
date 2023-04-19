// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:
// Os produtos terão os seguintes atributos:

// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.

using System.Globalization;

// Funcoes !!!

// Funcao Login

static void Login()
{

    bool senhaCerta = false;

    do
    {

        Console.WriteLine($"Digite sua senha numérica: ");
        int senha = int.Parse(Console.ReadLine()!);

        if (senha == 10205)
        {
            senhaCerta = false;
            Console.WriteLine($"");
            Console.WriteLine($"Login realizado com sucesso, bem vindo(a) a nossa loja!");

        }
        else
        {
            senhaCerta = true;
            Console.WriteLine($"Senha incorreta!");
        }

    } while (senhaCerta == true);
}


//Funcao Cadastro !

string[] nomes = new string[10];
float[] precos = new float[10];
bool[] promocoes = new bool[10];
// string respostaPromocao;

static void CadastrarProduto(string[] nomes, float[] precos, bool[] promocoes)
{
        for (var i = 0; i < 10; i++)
    {
        Console.WriteLine($"Digite o nome do produto: ");
        nomes[i] = Console.ReadLine()!;

        Console.WriteLine($"Digite o preço do produto: ");
        precos[i] = int.Parse(Console.ReadLine()!);

        check:
        Console.WriteLine($"O produto está em promoção ? (utilize 'S' para sim e 'N' para não) ");
        string respostaPromocao = Console.ReadLine()!.ToUpper();

        if (respostaPromocao == "S")
        {
            promocoes[i] = true;
        }
        else if (respostaPromocao == "N") 
        {
            promocoes[i] = false;
        }
        else 
        {
            Console.WriteLine($"Opção inválida, tente novamente!");
            goto check;
        }

    }
}

// Funcao Listar 

static void ListarProdutos(string[] nomes, float[] precos, bool[] promocoes)
{
        for (var i = 0; i < 10; i++)
    {
        Console.WriteLine(@$"

        ******************
        Lista de Produtos:

        Nome: {nomes[i]}

        Preco: {precos[i].ToString("C", new CultureInfo("pt-BR"))}

        O produto esta em promoção ? {promocoes[i]}

        ");
    }
}



// Progama

Console.WriteLine($"Faça seu login abaixo para entrar: ");
Console.WriteLine($"");
Console.WriteLine($"Digite seu nome de usuário: ");
string nomeUsuario = Console.ReadLine()!;
Login();
Console.WriteLine($"");

Console.WriteLine($"Pressione 'Enter' para prosseguir ao menu!");
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
|   1. Cadastrar produtos  | 
|   2. Listar produtos     |
|                          |
----------------------------

");

    string repostaMenu = Console.ReadLine()!;

    if (repostaMenu == "1")
    {
        Console.WriteLine($"");
        Console.WriteLine($"Bem vindo a tela de cadastro de produtos !");
        Console.WriteLine($"");
        CadastrarProduto(nomes, precos, promocoes);
        Console.WriteLine($"Pressione 'Enter' para voltar ao menu!");
        Console.ReadLine();
        
        goto menu;
        
    }

    else if (repostaMenu == "2")
    {
        Console.WriteLine($"Você escolheu a função listar produtos!");
        ListarProdutos(nomes, precos, promocoes);
        Console.WriteLine($"Pressione 'Enter' para voltar ao menu!");
        Console.ReadLine();
    }
    
    else
    {
        Console.WriteLine($"Opção inválida, escolha uma opção válida!");
        repostaMenu = Console.ReadLine()!;
    }


} while (menuResposta == true);
