namespace exercicio_fixacao_interface_agenda
{
    public class ContatoPessoal : Contato, IContatoPessoal
    {
        public string Cpf { get; set; }
        public bool ValidarCpf(string _cpf)
        {
            Cpf = _cpf;

            if (Cpf.Length == 14)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    }
}