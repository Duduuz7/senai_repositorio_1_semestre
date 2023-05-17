namespace projeto_produtos_poo
{
    public class Login
    {
        public bool Logado { get; private set; }
        public Login()
        {
            Usuario user = new Usuario();
            Logar(user);

            if (this.Logado == true)
            {
                GerarMenu();
            }
        }
        public void Logar(Usuario _usuario)
        {
        cadastro:
            Console.WriteLine($"Informe seu email: ");
            string emailDigitado = Console.ReadLine()!;

            Console.WriteLine($"Informe sua senha: ");
            string senhaDigitada = Console.ReadLine()!;

            if (emailDigitado == _usuario.Email && senhaDigitada == _usuario.Senha)
            {
                this.Logado = true;
                Console.WriteLine($"Login efetuado com sucesso !!!!");
            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"Falha ao logar");
                goto cadastro;

            }
        }

        public void Deslogar()
        {
            this.Logado = false;
            Console.WriteLine($"Deslogado com sucesso !!!");
        }

        public void GerarMenu()
        {
            Produto _produto = new Produto();
            Marca _marca = new Marca();

            Console.WriteLine(@$"

            [1] - Cadastrar Produto
            [2] - Listar Produto
            [3] - Remover Produto
            ========================
            [4] - Cadastrar Marca
            [5] - Listar Marca
            [6] - Remover Marca

            [0] - Sair
            
            ");

            string opcao = Console.ReadLine()!;

            do
            {
                 switch (opcao)
            {
                case "1":
                    _produto.Cadastrar();
                    break;

                case "2":
                    _produto.Listar();
                    break;

                case "3":
                    Console.WriteLine($"Informe o codigo do produto que deseja remover: ");
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
                    Console.WriteLine($"Informe o codigo da marca que deseja remover: ");
                    int removerMarcaCod = int.Parse(Console.ReadLine()!);
                    _marca.Deletar(removerMarcaCod);
                    break;

                case "0":
                    Console.WriteLine($"APP encerrado !");
                    break;

                default:
                    Console.WriteLine($"Opção inválida !");
                    break;
            }
            } while (opcao != "0");
           


        }
    }
}