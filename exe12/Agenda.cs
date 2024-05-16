using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe12
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Altura { get; set; }

        public Pessoa(string nome, int idade, float altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }
    }

    public class Agenda
    {
        private List<Pessoa> pessoas = new List<Pessoa>();

        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            pessoas.Add(new Pessoa(nome, idade, altura));
        }

        public void RemovePessoa(string nome)
        {
            pessoas.RemoveAll(p => p.Nome == nome);
        }

        public Pessoa BuscaPessoa(string nome)
        {
            return pessoas.Find(p => p.Nome == nome);
        }

        public void ImprimeAgenda()
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Altura: {pessoa.Altura}");
            }
        }
    }
}
