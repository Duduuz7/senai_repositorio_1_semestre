// nullable disable

// crie uma classe produto
// com as propriedades : int Codigo, string Nome, float Preco
// crie um construtor vazio
// crie um construtor completo

using exercicio_fixacao_list;

// criar a lista de objetos(produtos)
List<Produto> produtos = new List<Produto>();

produtos.Add(
    new Produto(2563,"camiseta QuickSilver",19.90f)
);

produtos.Add(
    new Produto(1025,"tenis Naiki",50f)
);

Produto calcaDiesel = new Produto(1526,"Calca Disel",15f);
produtos.Add(calcaDiesel);

Console.WriteLine($"LISTA ANTIGA");
Console.WriteLine($"*************");

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço:{item.Preco:C} {produtos.IndexOf(item)}");
}

Produto produtoBuscado = produtos.Find(x => x.Codigo == 2563)!;

//[egando index produto buscado
int index = produtos.IndexOf(produtoBuscado);

// fazendo alteracao
produtoBuscado.Preco = 199.90f;

//remover 
produtos.RemoveAt(index);

// devolvendo com alteracao
produtos.Insert(index, produtoBuscado);

Console.WriteLine($"LISTA ATUALIZADA");
Console.WriteLine($"****************");

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço:{item.Preco:C} {produtos.IndexOf(item)}");
}

// Console.WriteLine($"{produtoBuscado.Nome}, {produtoBuscado.Nome}, {produtoBuscado.Preco}");