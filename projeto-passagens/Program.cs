//Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.
// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:
// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).
// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

// FUNCOES


// Funcao Login

static void Login()
{

//corpo da funcao

    bool senhaCerta = false;

    do
    {

        Console.WriteLine($"Digite sua senha numérica: ");
        int senha = int.Parse(Console.ReadLine()!);

        if (senha == 12345)
        {
            senhaCerta = false;
            Console.WriteLine($"");
            Console.WriteLine($"Login realizado com sucesso!");

        }
        else
        {
            senhaCerta = true;
            Console.WriteLine($"Senha incorreta!");

        }

    } while (senhaCerta == true);
}



// Funcao Cadastro

string[] nomes = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];

static void Cadastro(string[] nomes, string[] origem,string[] destino, string[] data)
{

    for (var i = 0; i < 5; i++)
    {
        Console.WriteLine($"Digite o nome do passageiro: ");
        nomes[i] = Console.ReadLine()!;

        Console.WriteLine($"Digite a origem do passageiro: ");
        origem[i] = Console.ReadLine()!;

        Console.WriteLine($"Digite o destino do passageiro: ");
        destino[i] = Console.ReadLine()!;

        Console.WriteLine($"Digite a data de voo do passageiro: ");
        data[i] = Console.ReadLine()!;
    }    
}

// funcao listar

static void Listar(string[] nomes, string[] origem,string[] destino, string[] data)
{
    for (var i = 0; i < 5; i++)
    {
        Console.WriteLine(@$"

        ********************
        Passagens - Bilhete

        Nome: {nomes[i]}

        Origem: {origem[i]}

        Destino: {destino[i]}

        Data: {data[i]}

        ");
        
    }
}



// Program

Console.WriteLine($"Bem vindo a telo de login !");
Console.WriteLine($"");
Console.WriteLine($"Informe seu nome de usuário: ");
string nome = Console.ReadLine()!;

Login();


menuCheck:

    bool menuResposta = false;

    do
    {

        Console.Clear();
        Console.WriteLine(@$"

----------------------------
| Bem vindo ao nosso menu! |
|                          |
|  Escolha uma das opções: |   
|                          |
|   1. Cadastrar passagem  | 
|   2. Listrar passagens   |
|   0. Sair                |
|                          |
----------------------------

");

        int repostaMenu = int.Parse(Console.ReadLine()!);

        if (repostaMenu == 1)
        {
            Console.WriteLine($"");
            Console.WriteLine($"Bem vindo a tela de cadastro de passagens !");
            Console.WriteLine($"");

            Cadastro(nomes, origem, destino, data);

             Console.WriteLine(@$"
    
    Cadastro realizado com sucesso! 
    
    Deseja cadastrar uma nova passagem ? 
    
    Utilize (s) para sim e (n) para não.

    ");
        char respostaCadastro = char.Parse(Console.ReadLine()!.ToLower()!);

        bool respostaCadastroErro = false;

        do
        {

            if (respostaCadastro == 's')
            {
                Cadastro(nomes, origem, destino, data);
                Console.WriteLine($"");
                respostaCadastroErro = false;
            }

            else if (respostaCadastro == 'n')
            {
                goto menuCheck;
            }
            else
            {
                respostaCadastroErro = true;
                Console.WriteLine($"Resposta inválida, tente novamente !");
                respostaCadastro = char.Parse(Console.ReadLine()!);

            }

        } while (respostaCadastroErro == true);

        }


        else if (repostaMenu == 2)
        {
            Console.WriteLine($"Você escolheu a função listar!");
            Listar(nomes, origem, destino, data);
        }

        else if (repostaMenu == 0)
        {
            Console.WriteLine($"Obrigado poe acessar nosso progama, volte sempre!!!");
        }

        else
        {
            Console.WriteLine($"Opção inválida, escolha uma opção válida!");
            repostaMenu = int.Parse(Console.ReadLine()!);
        }


    } while (menuResposta == true);









// EXEMPLOS PROFESSOR !!

// string[] nomes = new string[5];
// string[] origens = new string[5];
// string[] destinos = new string[5];
// string[] datas = new string[5];


// cadastrarPassagens(nomes, origens, 0);
// cadastrarPassagens(nomes, origens, 1);


// for (int i = 0; i < nomes.Length; i++)
// {
//     Console.WriteLine($"Nome: {nomes[i]}");
//     Console.WriteLine($"Origem: {origens[i]}");
//     Console.WriteLine();
    
// }



// // Aqui a passagem de parâmetros do array nomes veio por referência!!!!!!!!!!
// static void cadastrarPassagens(string[] ns, string[] os, int pos)
// {
//     ns[pos] = "Eduardo";
//     os[pos] = "Rio";
// }