using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe01
{
    class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, decimal preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public void AdicionarItem(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverItem(int quantidade)
        {
            if (Quantidade >= quantidade)
            {
                Quantidade -= quantidade;
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente em estoque.");
            }
        }
    }
}
