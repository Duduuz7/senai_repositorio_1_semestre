using aula_poo_exemplo;

//Instanciar um objeto da classe Personagem
Personagem p1 = new Personagem();

Console.WriteLine($"Informe o nome do personagem: ");
p1.nome = Console.ReadLine()!;

Console.WriteLine($"Informe a idade do personagem: ");
p1.idade = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe a armadura do personagem: ");
p1.armadura = Console.ReadLine()!;

Console.WriteLine($"Informe a IA do personagem: ");
p1.ia = Console.ReadLine()!;

Console.WriteLine($@"
{p1.nome}
{p1.idade}
{p1.armadura}
{p1.ia}
");

p1.Atacar();
p1.Defender();
p1.RestaurarArmadura();




