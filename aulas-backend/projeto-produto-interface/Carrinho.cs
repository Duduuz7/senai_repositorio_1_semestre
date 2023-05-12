namespace projeto_produto_interface
{
    public class Carrinho : ICarrinho //IMPLEMENTACAO, para interface a heranca se chama implementamento
    {
        //PROPRIEDADES
        public float Valor { get; set; }

        // Criar uma lista para manipular os nossos objetos
        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Atualizar(int _codigo, Produto _novoProduto)
        {
            carrinho.Find(x => x.Codigo == _codigo)!.Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo)!.Preco = _novoProduto.Preco;
        }

        public void Listar()
        {
            if (carrinho.Count > 0)
            {
                foreach (Produto item in carrinho)
                {
                    Console.WriteLine(@$"
                    Código: {item.Codigo}
                    Nome: {item.Nome}
                    Preço: {item.Preco:C}
                    
                    ");

                }
            }

            else
            {
                Console.WriteLine($"Carrinho vazio !!!");
            }
        }

        public void Remover(Produto _produto)
        {
           carrinho.Remove(_produto);
        }

        public void TotalCarrinho()
        {
            Valor = 0;

            if (carrinho.Count > 0)
            {
                foreach (Produto item in carrinho)
                {
                    Valor += item.Preco;
                }
                Console.WriteLine($"O total do seu carrinho é de: {Valor:C}");
            }
            else
            {
                Console.WriteLine($"Carrinho vazio !!!");
            }
        }


    }
}