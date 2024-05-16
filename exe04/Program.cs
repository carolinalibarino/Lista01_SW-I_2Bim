using exe04;

class Program
{
    static void Main(string[] args)
    {
        AgendaTelefonica agenda = new AgendaTelefonica();

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adicionar contato");
            Console.WriteLine("2 - Remover contato");
            Console.WriteLine("3 - Buscar contato");
            Console.WriteLine("4 - Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Digite o nome do contato:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite o telefone do contato:");
                    string telefone = Console.ReadLine();
                    Console.WriteLine("Digite o email do contato:");
                    string email = Console.ReadLine();
                    agenda.AdicionarContato(nome, telefone, email);
                    break;
                case "2":
                    Console.WriteLine("Digite o nome do contato que deseja remover:");
                    nome = Console.ReadLine();
                    agenda.RemoverContato(nome);
                    break;
                case "3":
                    Console.WriteLine("Digite o nome do contato que deseja buscar:");
                    nome = Console.ReadLine();
                    agenda.BuscarContato(nome);
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}