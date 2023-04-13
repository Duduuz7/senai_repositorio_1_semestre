// Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

bool repetir = true;
// float alcool = 4.90f;
// float gasolina = 5.30f;
float litros = 0;
float valor = 0;

do
{


    Console.WriteLine(
        @$"Qual combustível você utilizou para abastecer seu veiculo ? 
    
    Utilize 'A' para álcool e 'G' para gasolina.

    ");

    char comb = char.Parse(Console.ReadLine()!);

    if (comb == 'A')
    {
        repetir = false;
        Console.WriteLine($"Você escolheu álcool !");
        Console.WriteLine($"Quantos litros de álcool você deseja ?");
        float alcool = float.Parse(Console.ReadLine()!);

       if (alcool <= 20)
       {
            valor = alcool * 4.90f;

            static float Desconto (float valor)
            {
                return valor * 3 / 100;
            }

            
       }
        
        
        
    }

    else if (comb == 'G')
    {
        repetir = false;
        Console.WriteLine($"Você escolheu gasolina !");
        Console.WriteLine($"Quantos litros de gasolina você deseja ?");
        float gasolina = float.Parse(Console.ReadLine()!);
    }

    else
    {
        repetir = true;
        Console.WriteLine($"Opção inválida, tente novamente !");
        
    }

} while (repetir);



    // Console.WriteLine($"Quantos litros você abasteceu ?");
    // litros = float.Parse(Console.ReadLine()!);

    // switch (comb)
    // {
    //     case 'A':

    //         valor = litros * alcool;

    //         break;

    //     case 'G':

    //         valor = litros * gasolina;

    //         break;
    //     default:

    //         repetir = true;

    //         break;

    // }

    // static float desconto (float valor)
    // {
        
    // }









// static float Gasolina (float litro)
// {

//     if (litros < 20)

// }
