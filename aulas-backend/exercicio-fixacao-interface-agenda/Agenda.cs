namespace exercicio_fixacao_interface_agenda
{
    public class Agenda : IAgenda
    {
        List<Contato> contatos = new List<Contato>();

        public void Adicionar(Contato _contato)
        {
            contatos.Add(_contato);
        }

        public void Listar()
        {
            foreach (var item in contatos)
            {
                Console.WriteLine(@$"
                
                ------------------
                Lista de contatos:
                Nome: {item.Nome}
                Número: {item.Telefone}
                Email: {item.Email}
            
                ");
                
            }
        }
    }
}