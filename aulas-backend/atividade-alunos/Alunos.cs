namespace atividade_alunos
{
    public class Alunos
    {
        public string nome;
        public string curso;
        public string idade;
        public string rg;
        public bool bolsa;
        public float mediaFinal;
        public float valorMensal;

        // FUNCOES !!!!!

        public void MostrarMedia()
        {
            Console.WriteLine($"Sua média final é: {mediaFinal}");   
        }

        public float MostrarMensalidade()
        {
            if (bolsa == true && mediaFinal >= 8)
            {
                return valorMensal / 2;
            }

            else if (bolsa == true && mediaFinal > 6 && mediaFinal < 8)
            {
                return valorMensal * 0.3F;
            }

            else 
            {
                return valorMensal;
            }
        }
    }
}