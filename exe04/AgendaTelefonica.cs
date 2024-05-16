using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe04
{
    class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }

    class AgendaTelefonica
    {
        private List<Contato> contatos;

        public AgendaTelefonica()
        {
            contatos = new List<Contato>();
        }

        public void AdicionarContato(string nome, string telefone, string email)
        {
            Contato contato = new Contato(nome, telefone, email);
            contatos.Add(contato);
            Console.WriteLine("Contato adicionado com sucesso!");
        }

        public void RemoverContato(string nome)
        {
            Contato contato = contatos.Find(c => c.Nome == nome);
            if (contato != null)
            {
                contatos.Remove(contato);
                Console.WriteLine("Contato removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }

        public void BuscarContato(string nome)
        {
            Contato contato = contatos.Find(c => c.Nome == nome);
            if (contato != null)
            {
                Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.Telefone}, Email: {contato.Email}");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }
    }

}
