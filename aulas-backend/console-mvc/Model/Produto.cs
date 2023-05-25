namespace console_mvc.Model
{
    public class Produto
    {
        //Propriedades

        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }

        //caminnho da pasta e do arquivo CSV
        //caminho é salvo na propriedade privada constante string

        private const string PATH = "Database/Produto.csv";

        //metodo construtor
        public Produto()
        {
            //criar a lógica para gerar a pasta e o arquivo

            //obter o caminho da pasta
            string pasta = PATH.Split("/")[0];

            //verificar se no caminho já existe uma pasta
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //verificar se no caminho já existe um arquivo
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        //metodo para ler os dados do arquivo csv

        public List<Produto> Ler()
        {
            //instancia da lista de produtos
            List<Produto> produtos = new List<Produto>();

            //array armazenando todas as linhas do csv
            string[] linhas = File.ReadAllLines(PATH);

            //leitura das linhas
            foreach (var item in linhas)
            {
                //separação de atributos de cada linha
                string[] atributos = item.Split(";");

                //instancia de produto
                Produto p = new Produto();

                //atribuição de valores dentro do objeto
                p.Codigo = int.Parse(atributos[0]);
                p.Nome = atributos[1];
                p.Preco = float.Parse(atributos[2]);

                //adiciona objeto dentro da lista
                produtos.Add(p);
            }
            //retorna 
            return produtos;
        }

        //método para preparar as linhas a serem inseridos no csv

        public string PrepararLinhasCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";//777;Coca;5,5

        }

        //metodo para inserir um produto na linha do csv

        public void Inserir(Produto p)
        {
            //array que armazena as linhas obtidas pelo método PrepararLinhasCSV
            string[] linhas = {PrepararLinhasCSV(p)};

            //inserir todas as linhas no arquivo dentro do PATH
            File.AppendAllLines(PATH, linhas);
        }
    }
}