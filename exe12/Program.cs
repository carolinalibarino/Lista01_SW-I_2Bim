namespace exe12
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Armazenar Pessoa");
                Console.WriteLine("2. Remover Pessoa");
                Console.WriteLine("3. Buscar Pessoa");
                Console.WriteLine("4. Imprimir Agenda");
                Console.WriteLine("5. Sair");

                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.Write("Altura: ");
                        float altura = float.Parse(Console.ReadLine());
                        agenda.ArmazenaPessoa(nome, idade, altura);
                        break;
                    case 2:
                        Console.Write("Nome da pessoa a ser removida: ");
                        string nomeRemover = Console.ReadLine();
                        agenda.RemovePessoa(nomeRemover);
                        break;
                    case 3:
                        Console.Write("Nome da pessoa a ser buscada: ");
                        string nomeBuscar = Console.ReadLine();
                        Pessoa pessoaEncontrada = agenda.BuscaPessoa(nomeBuscar);
                        if (pessoaEncontrada != null)
                        {
                            Console.WriteLine($"Pessoa encontrada: Nome: {pessoaEncontrada.Nome}, Idade: {pessoaEncontrada.Idade}, Altura: {pessoaEncontrada.Altura}");
                        }
                        else
                        {
                            Console.WriteLine("Pessoa não encontrada na agenda.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Agenda:");
                        agenda.ImprimeAgenda();
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}