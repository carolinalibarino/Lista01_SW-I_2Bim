using exe05;

class Program
{
    static void Main(string[] args)
    {
        GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Remover tarefa");
            Console.WriteLine("3 - Listar tarefas");
            Console.WriteLine("4 - Verificar se há tarefas para hoje");
            Console.WriteLine("5 - Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Digite a descrição da tarefa:");
                    string descricao = Console.ReadLine();
                    Console.WriteLine("Digite a data de vencimento da tarefa (formato: dd/mm/aaaa):");
                    DateTime dataVencimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                    gerenciador.AdicionarTarefa(descricao, dataVencimento);
                    break;
                case "2":
                    Console.WriteLine("Digite a descrição da tarefa que deseja remover:");
                    descricao = Console.ReadLine();
                    gerenciador.RemoverTarefa(descricao);
                    break;
                case "3":
                    gerenciador.ListarTarefas();
                    break;
                case "4":
                    Console.WriteLine("Digite a descrição da tarefa que deseja verificar:");
                    descricao = Console.ReadLine();
                    bool paraHoje = gerenciador.TarefaParaHoje(descricao);
                    if (paraHoje)
                    {
                        Console.WriteLine("Esta tarefa deve ser executada hoje.");
                    }
                    else
                    {
                        Console.WriteLine("Esta tarefa não deve ser executada hoje.");
                    }
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}