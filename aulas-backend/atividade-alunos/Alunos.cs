namespace atividade_alunos
{
    public class Alunos
    {
        //Atributos-caracteristicas-propriedades !!!
        public string Nome;
        public string Curso;
        public string Idade;
        public string Rg;
        public bool Bolsa;
        public float MediaFinal;
        public float ValorMensal;

        // COMPORTAMENTOS - MÉTODOS - FUNCOES !!!!!

        public void MostrarMedia()
        {
            Console.WriteLine($"A média final do aluno {Nome} é: {this.MediaFinal}");   
        }

        public float MostrarMensalidade()
        {
            if (Bolsa == true && MediaFinal >= 8)
            {
                return (this.ValorMensal * 0.5f);
            }

            else if (Bolsa == true && MediaFinal > 6)
            {
                return (ValorMensal * 0.7f);
            }

            else 
            {
                return (this.ValorMensal);
            }
        }
    }
}