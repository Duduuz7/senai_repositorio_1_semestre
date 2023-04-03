
Console.WriteLine($"Insira sua data de nascimento: ");

int data = int.Parse(Console.ReadLine()!);

int anoAtual = DateTime.Now.Year;



int ano = (DateTime.Now.Year - data);

Console.WriteLine($"Sua idade e de {ano} anos");

int semana = (data * 52);

Console.WriteLine($"Sua idade em semanas e de {semana} semanas");

