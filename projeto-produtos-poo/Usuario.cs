namespace projeto_produtos_poo
{


    public class Usuario
    {
        // public Usuario()
        // {

        // }
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public void Cadastrar()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine($"");
            Console.WriteLine($"Bem vindo ao nosso APP de compras, vamos realizar seu cadastro !!!");
            Console.WriteLine($"");
            Console.WriteLine($"Pressione 'Enter' para prosseguir.");
            Console.ReadLine();

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine($"Digite seu nome de usuário: ");
            this.Nome = Console.ReadLine();

            Console.WriteLine($"Digite seu E-mail: ");
            this.Email = Console.ReadLine();


            Console.WriteLine($"Digite sua senha: ");
            this.Senha = Console.ReadLine();

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"");
            Console.WriteLine($"Cadastro realizado com sucesso !!!");
            Console.WriteLine($"");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Agora presicamos que você realize seu Login antes de prosseguir.");
            Console.WriteLine($"");
            Console.ResetColor();

        }
        public void Deletar()
        {
            this.Nome = "";
            this.Email = "";
            this.Senha = "";
            this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }

    }
}