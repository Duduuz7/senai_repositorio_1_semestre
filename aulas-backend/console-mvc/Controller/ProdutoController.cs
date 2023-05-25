using console_mvc.Model;
using console_mvc.View;

namespace console_mvc.Controller
{
    public class ProdutoController
    {
        //instancia das classes produto e produtoView
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        //método controlador para acessar a listagem de produtos
        public void ListarProdutos()
        {
            //chamada da model trazendo a lista
            List<Produto> produtos = produto.Ler();

            //chamada da view passando a lista
            produtoView.Listar(produtos);
        }

        public void CadastrarProduto()
        {

            Produto novoProduto = produtoView.Cadastrar();

            produto.Inserir(novoProduto);

        }
    }
}