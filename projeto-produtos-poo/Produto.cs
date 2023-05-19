namespace projeto_produtos_poo
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string NomeProduto { get; private set; }
        public float Preco { get; private set; }
        public DateTime DataCadastro = DateTime.Now;
        public Marca Marca = new Marca();
        public Usuario CadastradoPor = new Usuario();
        List<Produto> Produtos = new List<Produto>();

        public void Cadastrar(Usuario user)
        {
            Produto p1 = new Produto();
            Marca m = new Marca();
            p1.CadastradoPor = user;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine($"Digite o código do produto:");
            p1.Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Digite o nome do produto:");
            p1.NomeProduto = Console.ReadLine()!;

            Console.WriteLine($"Digite o preço do produto:");
            p1.Preco = float.Parse(Console.ReadLine()!);

            Console.ResetColor();

            p1.DataCadastro = DateTime.Now;

            p1.Marca = m.Cadastrar();

            Produtos.Add(p1);
        }
        public void Listar()
        {
            if (Produtos.Count > 0)
            {
                foreach (var item in Produtos)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(@$"

                    ---------------------------------------------
                     Código do produto: {item.Codigo}          
                     Nome do produto: {item.NomeProduto}       
                     Preço do produto: {item.Preco:C2}       
                     Marca: {item.Marca.NomeMarca}     
                     Data do cadastro: {item.DataCadastro}     
                     Produto cadastrado por {item.CadastradoPor.Nome}           
                    ---------------------------------------------
                
                ");
                    Console.ResetColor();
                }
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Não há produtos na lista !!!");
                Console.ResetColor();
            }

        }
        public void Deletar(int removerProdutoCod)
        {
            Produto pd = Produtos.Find(x => x.Codigo == removerProdutoCod)!;
            Produtos.Remove(pd);
            Console.WriteLine($"");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"O produto cujo o código é {removerProdutoCod} foi removido !!!");
            Console.ResetColor();
        }

    }
}