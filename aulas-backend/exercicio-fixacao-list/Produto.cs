using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_fixacao_list
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco  { get; set; }

        public Produto()
        {
        }

        public Produto(int codigo, string nome, float preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco; 
        }
    }
}