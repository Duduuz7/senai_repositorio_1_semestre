//Instancia objeto carrinho

using projeto_produto_interface;

Carrinho carrinho = new Carrinho();

//Instanciar objeto(s) da classe Produto

Produto p1 = new Produto(1, "GTA 5", 52.90f);
Produto p2 = new Produto(2, "Detroit Become Human", 120.50f);
Produto p3 = new Produto(3, "Forza", 100f);

carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

carrinho.Listar();

carrinho.TotalCarrinho();

carrinho.Remover(p2);
carrinho.Remover(p3);

carrinho.Listar();

carrinho.TotalCarrinho(); 

Console.WriteLine($"Agora vamos atualizar um objeto !!!");

//Criar um objeto com os dados atualizados

Produto _novoProduto = new Produto();
_novoProduto.Nome = "FIFA 2023";
_novoProduto.Preco = 300F;

carrinho.Atualizar(1, _novoProduto);

carrinho.Listar();

carrinho.TotalCarrinho();