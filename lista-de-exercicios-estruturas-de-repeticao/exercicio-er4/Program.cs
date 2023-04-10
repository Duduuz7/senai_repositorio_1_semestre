// 4. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.


//saber o sexo do intrevistado
//saber se essa pessoa gostou do produto

//saber o numero de pessoas que responderam sim
//saber o numero de pessoas que responderam nao

//saber o numero de mulheres que responderam
//saber a quantidade de mulheres que responderam sim

//saber o numero de homens que responderam
//saber o numero de homens que responderam nao

//saber a porcentagem de homens que responderam nao ----- exibido


//declarar as variaveis

char sexo; 
char gostouDoProduto;

int totalSim = 0;
int totalNao = 0;

int totalMulher = 0;
int totalMulherSim = 0;

int totalHomemNao = 0;
int totalHomem = 0;

float porcentagemHomemNao = 0;

//primeiro valor inicializador, segundo condicional, ate onde vai, e terceiro iterador
for (var i = 1; i < 10; i++)
{
    //entrada de dados

    Console.WriteLine(@$"
    Informe o sexo da pessoa: 
    (m) - Masculino
    (f) - Feminino
    ");
    
    sexo = char.Parse(Console.ReadLine()!.ToLower());
    
    //processamento

    if (sexo == 'f')
    {
        totalMulher++;
    }
    else
    {
        totalHomem++;
    }

    Console.WriteLine(@$"
    A pessoa gostou do lançamento ?
    (s) - Sim
    (n) - Não
    ");

    gostouDoProduto = char.Parse(Console.ReadLine()!.ToLower());
    
    if (gostouDoProduto == 's')
    {
        totalSim++;

        if (sexo == 'f')
        {
            totalMulherSim++;
        }
    }

    else
    {
        totalNao++;

        if (sexo == 'm')
        {
            totalHomemNao++;
        }

    }
}

porcentagemHomemNao = ((float)totalHomemNao / (float)totalHomem)*100;


Console.WriteLine($"O total de pessoas que responderam sim foi de : {totalSim}");
Console.WriteLine($"O total de pessoas que responderam não foi de : {totalNao}");

Console.WriteLine($"O total de mulheres que responderam sim foi de : {totalMulherSim}");

Console.WriteLine($"A porcentagem de homens que responderam que não gostaram no produto é de: {porcentagemHomemNao} %");
