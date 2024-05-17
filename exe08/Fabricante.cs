using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Fabricante
{
    public string Nome { get; private set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }

    public Fabricante(string nome, string endereco, string cidade)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("O nome do fabricante não pode ser vazio.");
        }

        Nome = nome;
        Endereco = endereco;
        Cidade = cidade;
    }
}


