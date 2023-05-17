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
            m1.DataCadastro = DateTime.Parse(Console.ReadLine()!);

            Marcas.Add(m1);
            Console.WriteLine($"Produto cadastrado com sucesso");
            return m1;
        }
        public void Listar()
        {
            if (Marcas.Count > 0)
            {
                foreach (var item in Marcas)
                {
                    Console.WriteLine(@$"
                ---------------------------------------
                | Código da marca: {Codigo}           |
                | Nome da marca: {NomeMarca}          | 
                | Data do cadastro: {DataCadastro}    |
                ---------------------------------------
                ");
                }
            }
            else
            {
                Console.WriteLine($"A lista de marcas está vazia !!!");
            }

        }
        public void Deletar(int removerMarcaCod)
        {
            Marca md = Marcas.Find(x => x.Codigo == removerMarcaCod)!;
            Marcas.Remove(md);
        }


    }
}

//.Find(x => x.Codigo == codigo); guardar dentro de objeto do tipo doq busquei
