//faça um método para calcular imposto sobre a renda

//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto

//receber o renda via console
//chamar o método passando a renda como parâmetro
//exibir o valor do imposto referente á renda

using System.Globalization; 

static float Imposto(float rendimento)
{

    if (rendimento <= 1500)
    {
        return 0;
    }

    else if (rendimento > 1500 && rendimento <= 3500)
    {
        return (rendimento * 20) / 100;
    }

    else if (rendimento > 3500 && rendimento <= 6000)
    {
        return (rendimento * 25) / 100;
    }

    else
    {
        return (rendimento * 35) / 100;
    }

}

Console.WriteLine($"Informe sua renda: ");
float rendimento = float.Parse(Console.ReadLine()!);

float resultado = Imposto(rendimento);

Console.WriteLine($"Você vai pagar {resultado.ToString("C", new CultureInfo("pt-BR"))} de imposto !"); // crtl ponto e using system.Globalization


