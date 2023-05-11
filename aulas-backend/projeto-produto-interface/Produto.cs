namespace projeto_produto_interface
{
    public class Produto
    {
        //PROPRIEDADES

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        //CONSTRUTORES

        public Produto()
        {
        }

        public Produto(int _codigo, string _nome, float _preco)
        {
            Codigo = _codigo;
            Nome = _nome;
            Preco = _preco;
        }

    }
}