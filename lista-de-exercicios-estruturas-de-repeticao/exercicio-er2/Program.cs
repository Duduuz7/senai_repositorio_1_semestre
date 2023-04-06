// 2. Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.



bool senhaCerta = false;

do
 {

    Console.WriteLine($"Informe seu nome de usuário: ");
    string nome = Console.ReadLine()!;

    Console.WriteLine($"Informe sua senha: ");
    string senha = Console.ReadLine()!;
    
    if (senha == nome)
    {
        senhaCerta = true;
        Console.WriteLine($"Sua senha não pode ser igual ao seu nome de usuário, tente algo diferente !");
        
    }

    else
    {
        Console.WriteLine($"Cadastro Realizado com sucesso !");

    }
    
} while (senhaCerta == true);