using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_fixacao_list2_carro
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Cor { get; set; }

        public Carro()
        {
        }

        public Carro(string marca, string cor)
        {
            Marca = marca;
            Cor = cor;
        }

    }
}