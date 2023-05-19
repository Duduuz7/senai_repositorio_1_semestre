namespace projeto_produtos_poo
{
    public class Marca
    {
        public int Codigo { get; private set; }
        public string NomeMarca { get; private set; }
        public DateTime DataCadastro { get; private set; }
        List<Marca> Marcas = new List<Marca>();

        public Marca Cadastrar()
        {
            Marca m1 = new Marca();

            Console.WriteLine($"Digite o código da marca:");
            m1.Codigo = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Digite o nome da marca:");
            m1.NomeMarca = Console.ReadLine()!;
            m1.DataCadastro = DateTime.Now;

            Marcas.Add(m1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Marca cadastrada com sucesso");
            Console.ResetColor();

            Console.WriteLine($"");

            return m1;
        }
        public void Listar()
        {
            if (Marcas.Count > 0)
            {
                foreach (var item in Marcas)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(@$"
                ----------------------------------------
                 Código da marca: {item.Codigo}           
                 Nome da marca: {item.NomeMarca}          
                 Data do cadastro: {item.DataCadastro}    
                ----------------------------------------
                ");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A lista de marcas está vazia !!!");
                Console.ResetColor();
            }

        }
        public void Deletar(int removerMarcaCod)
        {
            Marca md = Marcas.Find(x => x.Codigo == removerMarcaCod)!;
            Marcas.Remove(md);
            Console.WriteLine($"");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A marca cujo o código é {removerMarcaCod} foi removida !!!");
            Console.ResetColor();
        }


    }
}