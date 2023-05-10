// Criar um projeto de console
// Criar uma classe Carro com propriedade marca e cor
// Criar construtor vazio e completo
// Receber dados no console para adicionar 2 objetos em uma lista
// Exibir os dois objetos da lista no Console

// MINHA RESOLUCAO +/-

using exercicio_fixacao_list2_carro;

List<Carro> carros = new List<Carro>();

// Console.WriteLine($"Digite a marca e logo em seguida a cor do primeiro carro: ");

// carros.Add(
//     new Carro(Console.ReadLine(), Console.ReadLine())  
// );

// Console.WriteLine($"Digite a marca e logo em seguida a cor do segundo carro: ");

// carros.Add(
//     new Carro(Console.ReadLine(), Console.ReadLine())  
// );

// foreach (var item in carros)
// {
//     Console.WriteLine($"Marca do {carros.IndexOf(item) +1}º carro: {item.Marca} Cor: {item.Cor}");
// }


// RESOLUCAO PROFESSOR:

for (var i = 0; i < 2; i++)
{
    Carro carro = new Carro();

    Console.WriteLine($"Informe a marca do carro: ");
    carro.Marca = Console.ReadLine()!;
    
    Console.WriteLine($"Informe a cor o carro: ");
    carro.Cor = Console.ReadLine()!;
    
    carros.Add(carro);
}

foreach (var item in carros)
{
    Console.WriteLine($"Marca: {item.Marca} - Cor {item.Cor}");
}
