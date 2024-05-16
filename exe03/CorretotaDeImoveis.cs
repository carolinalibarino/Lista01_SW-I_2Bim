using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe03
{
    class Imovel
    {
        public string Endereco { get; set; }
        public double Preco { get; set; }
        public string Tipo { get; set; }

        public Imovel(string endereco, double preco, string tipo)
        {
            Endereco = endereco;
            Preco = preco;
            Tipo = tipo;
        }
    }

    class CorretoraDeImoveis
    {
        private List<Imovel> imoveis;

        public CorretoraDeImoveis()
        {
            imoveis = new List<Imovel>();
        }

        public void AdicionarImovel(string endereco, double preco, string tipo)
        {
            Imovel imovel = new Imovel(endereco, preco, tipo);
            imoveis.Add(imovel);
            Console.WriteLine("Imóvel adicionado com sucesso!");
        }

        public void AlterarPreco(string endereco, double novoPreco)
        {
            Imovel imovel = imoveis.Find(i => i.Endereco == endereco);
            if (imovel != null)
            {
                imovel.Preco = novoPreco;
                Console.WriteLine("Preço do imóvel alterado com sucesso!");
            }
            else
            {
                Console.WriteLine("Imóvel não encontrado.");
            }
        }

        public void ListarImoveis()
        {
            Console.WriteLine("Lista de imóveis disponíveis:");
            foreach (Imovel imovel in imoveis)
            {
                Console.WriteLine($"Endereço: {imovel.Endereco}, Preço: {imovel.Preco}, Tipo: {imovel.Tipo}");
            }
        }

        public double CalcularValorMedio()
        {
            if (imoveis.Count == 0)
            {
                Console.WriteLine("Não há imóveis disponíveis para calcular o valor médio.");
                return 0;
            }
            double somaPrecos = imoveis.Sum(i => i.Preco);
            return somaPrecos / imoveis.Count;
        }
    }
}
