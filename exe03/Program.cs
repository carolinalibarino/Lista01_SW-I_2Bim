using exe03;

CorretoraDeImoveis corretora = new CorretoraDeImoveis();

while (true)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Inserir imóvel");
    Console.WriteLine("2 - Alterar preço do imóvel");
    Console.WriteLine("3 - Listar todos os imóveis");
    Console.WriteLine("4 - Calcular valor médio dos imóveis");
    Console.WriteLine("5 - Sair");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite o endereço do imóvel:");
            string endereco = Console.ReadLine();
            Console.WriteLine("Digite o preço do imóvel:");
            double preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o tipo do imóvel:");
            string tipo = Console.ReadLine();
            corretora.AdicionarImovel(endereco, preco, tipo);
            break;
        case "2":
            Console.WriteLine("Digite o endereço do imóvel cujo preço será alterado:");
            endereco = Console.ReadLine();
            Console.WriteLine("Digite o novo preço:");
            double novoPreco = Convert.ToDouble(Console.ReadLine());
            corretora.AlterarPreco(endereco, novoPreco);
            break;
        case "3":
            corretora.ListarImoveis();
            break;
        case "4":
            double valorMedio = corretora.CalcularValorMedio();
            Console.WriteLine($"O valor médio dos imóveis é: {valorMedio}");
            break;
        case "5":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}
