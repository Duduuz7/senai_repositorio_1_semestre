namespace projeto_produtos_poo
{


    public class Usuario
    {
        public Usuario()
        {
            Cadastrar();
        }
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public void Cadastrar()
        {
            this.Nome = "Eduardo";
            this.Email = "e";
            this.Senha = "1234";
            this.DataCadastro = DateTime.Now;
        }
        public void Deletar()
        {
            this.Nome = "";
            this.Email = "";
            this.Senha = "";
            this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }

    }
}