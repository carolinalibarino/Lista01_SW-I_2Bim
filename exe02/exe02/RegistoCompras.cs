using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe02
{
    class RegistroDeCompras
    {
        private List<(DateTime data, Produto produto, decimal valor)> compras;

        public RegistroDeCompras()
        {
            compras = new List<(DateTime, Produto, decimal)>();
        }

        public void AdicionarCompra(DateTime data, Produto produto, decimal valor)
        {
            compras.Add((data, produto, valor));
        }

        public void ListarCompras()
        {
            foreach (var compra in compras)
            {
                Console.WriteLine($"Data: {compra.data}, Produto: {compra.produto.Nome}, Valor: R${compra.valor}");
            }
        }
    }

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
    }
}
