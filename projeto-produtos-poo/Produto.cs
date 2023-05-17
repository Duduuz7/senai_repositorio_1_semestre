namespace projeto_produtos_poo
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string NomeProduto { get; private set; }
        public float Preco { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public Marca Marca = new Marca();
        public Usuario CadastradoPor { get; set; }
        List<Produto> Produtos = new List<Produto>();

        public void Cadastrar()
        {
            Produto p1 = new Produto();
            Marca m = new Marca();
            Usuario u = new Usuario();

            Console.WriteLine($"Digite o código do produto:");
            p1.Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Digite o nome do produto:");
            p1.NomeProduto = Console.ReadLine()!;
            
            Console.WriteLine($"Digite o preço do produto:");
            p1.Preco = float.Parse(Console.ReadLine()!);

            DataCadastro = DateTime.Now;

            p1.Marca = m.Cadastrar();

            Console.WriteLine($"Produto cadastrado com sucesso por {u.Nome}");
            
            Produtos.Add(p1);
            Console.WriteLine($"Produto cadastrado com sucesso");

        }
        public void Listar()
        {
            Usuario u = new Usuario();
            if (Produtos.Count > 0)
            {
                foreach (var item in Produtos)
                {
                    Console.WriteLine(@$"

                    ---------------------------------------------
                    | Código do produto: {this.Codigo}          |
                    | Nome do produto: {this.NomeProduto}       |
                    | Preço do produto: {this.Preco}            |
                    | Data do cadastro: {this.DataCadastro}     |
                    | Produto cadastrado por {u.Nome}           |
                    ---------------------------------------------
                
                ");
                }
            }

            else
            {
                Console.WriteLine($"Não há produtos na lista !!!");
            }

        }
        public void Deletar(int removerProdutoCod)
        {
            Produto pd = Produtos.Find(x => x.Codigo == removerProdutoCod)!;
            Produtos.Remove(pd);
        }

    }
}