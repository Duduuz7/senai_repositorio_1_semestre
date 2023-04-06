// 4. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.

//perguntar se e homem ou mulher, perguntar se gostou do produto,

int pessoasS = 0;
int pessoasN = 0;
int femS = 0;
int mascN = 0;

for (int contador = 0; contador < 10 ; contador++)
{
    Console.WriteLine($"Qual seu sexo ? Utilize 'm' para masculino e 's'.");
    char sexo = char.Parse(Console.ReadLine()!);

    Console.WriteLine($"Voce gostou do produto ? Utilize 's' para sim e 'n' para não.");
    char gosto = char.Parse(Console.ReadLine()!);

    switch (gosto)
    {
        case 's':
            pessoasS ++;

            if (sexo == 'f')
            {
                femS ++;
            }
            break;
        
        case 'n':
            pessoasN ++;

            if (sexo == 'm')
            {
                mascN ++;
            }
        break;
    }
}

