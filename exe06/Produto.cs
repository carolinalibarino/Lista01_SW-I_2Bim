using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe06
{

    class Produto
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }

        public Produto(string codigo, string nome, double preco, int quantidadeEmEstoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }

        public void AdicionarEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                QuantidadeEmEstoque += quantidade;
                Console.WriteLine($"{quantidade} unidades do produto {Nome} foram adicionadas ao estoque.");
            }
            else
            {
                Console.WriteLine("A quantidade a ser adicionada deve ser maior que zero.");
            }
        }

        public void RemoverEstoque(int quantidade)
        {
            if (quantidade > 0 && quantidade <= QuantidadeEmEstoque)
            {
                QuantidadeEmEstoque -= quantidade;
                Console.WriteLine($"{quantidade} unidades do produto {Nome} foram removidas do estoque.");
            }
            else if (quantidade > QuantidadeEmEstoque)
            {
                Console.WriteLine("A quantidade a ser removida excede o estoque disponível.");
            }
            else
            {
                Console.WriteLine("A quantidade a ser removida deve ser maior que zero.");
            }
        }
    }
}
