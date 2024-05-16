using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe05
{
    class Tarefa
    {
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }

        public Tarefa(string descricao, DateTime dataVencimento)
        {
            Descricao = descricao;
            DataVencimento = dataVencimento;
        }
    }

    class GerenciadorDeTarefas
    {
        private List<Tarefa> tarefas;

        public GerenciadorDeTarefas()
        {
            tarefas = new List<Tarefa>();
        }

        public void AdicionarTarefa(string descricao, DateTime dataVencimento)
        {
            Tarefa tarefa = new Tarefa(descricao, dataVencimento);
            tarefas.Add(tarefa);
            Console.WriteLine("Tarefa adicionada com sucesso!");
        }

        public void RemoverTarefa(string descricao)
        {
            Tarefa tarefa = tarefas.Find(t => t.Descricao == descricao);
            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
                Console.WriteLine("Tarefa removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }

        public void ListarTarefas()
        {
            Console.WriteLine("Lista de Tarefas:");
            foreach (Tarefa tarefa in tarefas)
            {
                Console.WriteLine($"Descrição: {tarefa.Descricao}, Data de Vencimento: {tarefa.DataVencimento.ToShortDateString()}");
            }
        }

        public bool TarefaParaHoje(string descricao)
        {
            Tarefa tarefa = tarefas.Find(t => t.Descricao == descricao);
            if (tarefa != null)
            {
                return tarefa.DataVencimento.Date == DateTime.Today;
            }
            return false;
        }
    }
}
