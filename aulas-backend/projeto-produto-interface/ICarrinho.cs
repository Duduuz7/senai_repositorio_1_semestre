namespace projeto_produto_interface
{
    //interfaceICarrinho
    public interface ICarrinho
    {
        //REGRAS DO "CONTRATO"
        //metodos que deverao aqui ser declarados apenas

        //CRUD : Create, Read, Update, Delete
          //modelo padrao de chamada de metodo:
           //tipo Nome(parametros)

        //Create
         
            void Adicionar(Produto _produto);


        //Read

        void Listar();



        //Update

        void Atualizar(int _codigo, Produto _produto);

        //Delete

        void Remover(Produto _produto);
    }
}