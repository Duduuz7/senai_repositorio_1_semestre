
//Coca cola
//Pepsi
//Fanta
//Monster

//crie um menu de opções e peça para o usuário escolher uma das opções
//a depender da opção, exiba uma mensagem se gostaria de acrescentar gelo
//se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo
//caso contrário, a bebida é sem gelo adicional

Console.WriteLine(@$"

----------------------------
| Menu Bebidas Burger King |
|                          |
|     Números bebidas      |   
|                          |
|      1. Coca cola        | 
|        2. Pepsi          |
|        3. Fanta          |
|       4. Guaraná         |
----------------------------

");

Console.WriteLine($"Informe o pedido: ");
int pedido = int.Parse(Console.ReadLine()!);

Console.WriteLine(@$" 

Deseja acrescentar gelo à sua bebida ?
Digite 1 para sim e 2 para não !

");

int gelo = int.Parse(Console.ReadLine()!);
int resultado = 0;

// Processamento / Saída

switch (pedido)
{
    case 1:

        if (gelo == 1)
            Console.WriteLine($"Sua bebida é Coca-Cola com adicional de gelo");

        else if (gelo == 2)
            Console.WriteLine($"Sua bebida é Coca-Cola sem gelo");

        else 
            Console.WriteLine($"Opção inválida !");
            

        break;

    case 2:

        if (gelo == 1)
            Console.WriteLine($"Sua bebida é Pepsi com adicional de gelo");

        else if (gelo == 2)
            Console.WriteLine($"Sua bebida é Pepsi sem gelo");

        else 
            Console.WriteLine($"Opção inválida !");
        
        break;

    case 3:

        if (gelo == 1)
            Console.WriteLine($"Sua bebida é Fanta com adicional de gelo");

        else if (gelo == 2)
            Console.WriteLine($"Sua bebida é Fanta sem gelo");

        else 
            Console.WriteLine($"Opção inválida !");

        break;

    case 4:

        if (gelo == 1)
            Console.WriteLine($"Sua bebida é Guaraná com adicional de gelo");

        else if (gelo == 2)
            Console.WriteLine($"Sua bebida é Guaraná sem gelo");

        else 
            Console.WriteLine($"Opção inválida !");

        break;

    default:
        Console.WriteLine($"Pedido inválido, tente novamente !");

        break;
}