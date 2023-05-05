// 2.Você trabalha em uma empresa especialista em máquinas de fazer café e sua equipe é a responsável por desenvolver uma classe para o novo modelo de cafeteiras que irão fabricar.

// No modelo anterior das cafeteiras, os usuários podiam selecionar se era para ser adicionado açúcar ou não, mas a nova versão da Super CafeteiraTabajaras Plus++ deve ser capaz de receber a quantidade (em gramas) de açúcar a ser colocada no café. Mesmo com essa nova possibilidade, o usuário não será obrigado a informar quanto de açúcar deseja. Deve-se adicionar 10 gramas de açúcar por padrão caso nenhum valor seja informado.

// a. Para começar, crie a classe "MaquinaCafe" com um atributo chamado "acucarDisponivel", que será útil para saber a quantidade de açúcar disponível na máquina. Se o açúcar acabar, a máquina só permitirá cafezinhos sem açúcar, certo?

// b. Agora crie um método chamado "fazerCafe" na mesma classe. Esse método deve verificar se a quantidade de açúcar disponível na máquina é suficiente e, claro, fazer o café.

// c. Como o usuário não será obrigado a informar a quantidade de açúcar a ser adicionado no café, crie outro método com o nome "fazerCafe", que não recebe nenhum parâmetro. Isso é uma sobrecarga de métodos!

using exercicio_2_cafeteira;
MaquinaCafe m1 = new MaquinaCafe();

bool menu = true;

string adicionarCafe;

do
{
    Console.WriteLine(@$"
        Menu cafeteria!

    [1] Pedir café
    [2] Sair
");

    string resposta = Console.ReadLine()!;

voltarMenu:
    switch (resposta)
    {
        case "1":
            menu = false;
            Console.WriteLine(@$"
            Deseja adicionar açucar ao café?

            [1] SIM
            [2] NÃO
            ");

            adicionarCafe = Console.ReadLine()!;
            switch (adicionarCafe)
            {
                case "1":
                    m1.FazerCafe(m1.acucarDisponivel);
                    break;
                case "":
                    m1.FazerCafe();
                    break;
                case "2":
                    Console.WriteLine($"Seu café sem açucar está pronto!");
                    break;
                default:
                    Console.WriteLine($"Insira uma resposta válida!");
                    goto voltarMenu;
            }

            break;
        case "2":
            menu = false;
            break;
        default:
            menu = true;
            Console.WriteLine($"Resposta inválida, insira uma opção correta!");
            break;
    }
} while (menu);