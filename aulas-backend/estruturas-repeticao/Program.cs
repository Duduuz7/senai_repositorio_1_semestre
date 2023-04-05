// WHILE ***************************

// //Valor Inicial
// int x = 1;

// while (x <= 10) // Enquanto x for menor ou igual a 10
// {
//     Console.WriteLine(x); // Imprima o valor de x
//     x+= 2; // Depois incrementa +1 ao valor de x
// }




// bool idadeCerta = false;

// while (!(idadeCerta == true))
// {
//     Console.WriteLine($"Qual a idade do CR7 ?");
//     int idade = int.Parse(Console.ReadLine());

//     if (idade == 38)
//     {
//         idadeCerta = true;
//     }    
// }






// Console.WriteLine($"Informe o nome do usuário: ");
// string nome = Console.ReadLine();

// Console.WriteLine($"Informe a senha com 6 caracteres: ");
// string senha = Console.ReadLine();

// while (senha.Length != 6)
// {
//     Console.WriteLine($"Infome a senha novamente, tem que ter 6 caracteres");
//     senha = Console.ReadLine();   
// }
// Console.WriteLine($"Usuário e senha recebidos com sucesso!");




// DO WHILE *********************


// bool idadeCerta = false;
// do
// {
//     Console.WriteLine($"Qual a idade do CR7 ?");
//     int idade = int.Parse(Console.ReadLine());

//     if(idade == 38)
//     {
//         Console.WriteLine($"Acertou!!");
//         idadeCerta = true;        
//     }
//     else
//     {
//         Console.WriteLine($"Errou feio, tente novamente!");        
//     }
    
// } while (idadeCerta == false);







// FOR *******************


// for (inicializador; condição; iterador)

// for(int x = 0; x <= 100; x++)
// {
//     Console.WriteLine(x);
// }





// operador de incremento

// de 1 em 1

//x++;
//x = x+1;
//x+=1;

// acima de 1

//x = x+3;
//x += 3;





//Programa para imprimir valores de 500 até 0, decrementar de 5 em 5

for (int y = 500; y >= 0; y -= 5)
{
    Console.WriteLine(y);
}