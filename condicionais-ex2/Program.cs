Console.WriteLine($"Informe a quantidade de gols feitos pelo time 1: ");

int time1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe a quantidade de gols feitos pelo time 2: ");

int time2 = int.Parse(Console.ReadLine()!);


if (time1 > time2)
{
    Console.WriteLine($"Vitoria do Time 1 !");    
}
else if (time1 == time2)
{
    Console.WriteLine($"Empate !");    
}

else 
{
    Console.WriteLine($"Vitoria do time 2 !");
}
