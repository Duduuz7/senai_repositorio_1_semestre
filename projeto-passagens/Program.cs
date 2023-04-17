//Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.
// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:
// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).
// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

Console.WriteLine($"Bem vindo a telo de login !");
Console.WriteLine($"");
Console.WriteLine($"Informe seu nome de usuário: ");
string nome = Console.ReadLine()!;


static void Login()
{
    bool senhaCerta = false;

    do
    {

        Console.WriteLine($"Digite sua senha numérica (5 digitos): ");
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
            Console.WriteLine($"Senha inválida, tente novamente!");

        }

    } while (senhaCerta == true);
}

Login();

Menu();

static void Cadastro()
{

    string[] nomes = new string[5];
    string[] origem = new string[5];
    string[] destino = new string[5];
    string[] data = new string[5];


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

        Console.WriteLine(@$"
    
    Cadastro realizado com sucesso! 
    
    Deseja cadastrar uma nova passagem ? 
    
    Utilize (1) para sim e (2) para não.

    ");

        int respostaCadastro = int.Parse(Console.ReadLine()!);

        if (respostaCadastro == 1)
        {
            Cadastro();
            Console.WriteLine($"");
        }

        else if (respostaCadastro == 2)
        {

        }
    }

}


// static void Listar()
// {
//     foreach (var cadastro in collection)
//     {

//     }
// }

static void Menu()
{

    bool menuResposta = false;

    do
    {


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

            Cadastro();
        }


    } while (menuResposta == true);

}

