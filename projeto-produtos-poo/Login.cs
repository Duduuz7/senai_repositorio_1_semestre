namespace projeto_produtos_poo
{
    public class Login
    {
        public bool Logado { get; private set; }
        public Login()
        {
            Usuario user = new Usuario();
            user.Cadastrar();
            Logar(user);

            if (this.Logado == true)
            {
                GerarMenu(user);
            }
        }
        public void Logar(Usuario _usuario)
        {

        cadastro:
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Informe seu email: ");
            string emailDigitado = Console.ReadLine()!;

            Console.WriteLine($"Informe sua senha: ");
            string senhaDigitada = Console.ReadLine()!;
            Console.ResetColor();

            if (emailDigitado == _usuario.Email && senhaDigitada == _usuario.Senha)
            {
                Usuario user = new Usuario();
                this.Logado = true;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"");
                Console.WriteLine($"Login efetuado com sucesso !!!!");
                Console.WriteLine($"");

                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"Bem vindo ao nosso aplicativo de compras {user.Nome}, pressione 'Enter' para prosseguir ao menu !!!");
                Console.ReadLine();
                Console.ResetColor();
            }
            else
            {
                this.Logado = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"");
                Console.WriteLine($"Falha ao logar, tente novamente !!!");
                Console.WriteLine($"");
                Console.ResetColor();
                goto cadastro;


            }
        }

        public void Deslogar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            this.Logado = false;
            Console.WriteLine($"");
            Console.WriteLine($"Deslogado com sucesso !!!");
            Console.WriteLine($"");
            Console.ResetColor();

        deslogarVoltar:

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Deseja efetuar outro login ou sair do APP ? (utilize 'S' para sair e 'N' para efetuar um novo cadastro e login !!!)");
            string respostaDeslogar = Console.ReadLine().ToUpper();
            Console.ResetColor();

            if (respostaDeslogar == "S")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"");
                Console.WriteLine($"Obrigado por utilizar nosso APP, volte sempre !!!");
                Console.ResetColor();
            }
            else if (respostaDeslogar == "N")
            {
                Usuario user = new Usuario();
                user.Cadastrar();
                Logar(user);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Opção inválida, tente novamente !!!");
                Console.ResetColor();
                goto deslogarVoltar;

            }


        }

        public void GerarMenu(Usuario usuario)
        {
            Produto _produto = new Produto();
            Marca _marca = new Marca();


            string opcao;
            do

            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine(@$"

            ============================
            [1] - Cadastrar Produto
            [2] - Listar Produto
            [3] - Remover Produto
            ============================
            [4] - Cadastrar Marca
            [5] - Listar Marca
            [6] - Remover Marca
            ============================
            [00] - Deslogar
            [0] - Fechar Programa/sair
            ============================

            ");
                Console.ResetColor();

                opcao = Console.ReadLine()!;


                switch (opcao)
                {
                    case "1":
                        _produto.Cadastrar(usuario);
                        break;

                    case "2":
                        _produto.Listar();
                        break;

                    case "3":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Informe o codigo do produto que deseja remover: ");
                        Console.ResetColor();

                        int removerProdutoCod = int.Parse(Console.ReadLine()!);
                        _produto.Deletar(removerProdutoCod);
                        break;

                    case "4":
                        _marca.Cadastrar();
                        break;

                    case "5":
                        _marca.Listar();
                        break;

                    case "6":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Informe o codigo da marca que deseja remover: ");
                        Console.ResetColor();

                        int removerMarcaCod = int.Parse(Console.ReadLine()!);
                        _marca.Deletar(removerMarcaCod);
                        break;

                    case "0":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"APP encerrado !");
                        Console.ResetColor();
                        break;
                    case "00":
                        Deslogar();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Opção inválida !");
                        Console.ResetColor();
                        break;
                }
            } while (opcao != "0" && opcao != "00");



        }
    }
}