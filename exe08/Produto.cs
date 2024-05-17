using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Produto
{
    private string nome;
    private decimal preco;

    public string Nome
    {
        get => nome;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome do produto não pode ser vazio.");
            }
            nome = value;
        }
    }

    public Fabricante Fabricante { get; set; }

    public decimal Preco
    {
        get => preco;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("O preço do produto deve ser positivo.");
            }
            preco = value;
        }
    }

    public Produto(string nome, Fabricante fabricante, decimal preco)
    {
        Nome = nome;
        Fabricante = fabricante;
        Preco = preco;
    }
}