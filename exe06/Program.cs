namespace exe06
{
    class Program
    {
        static List<Produto> listaProdutos = new List<Produto>();

        static void Main(string[] args)
        {
            // Adicionando alguns produtos à lista
            AdicionarProduto("P001", "Camiseta", 29.99, 50);
            AdicionarProduto("P002", "Calça Jeans", 59.99, 30);
            AdicionarProduto("P003", "Tênis Esportivo", 99.99, 20);

            // Exibindo todos os produtos na tela
            ExibirTodosProdutos();

            // Consultando um produto pelo código
            ConsultarProdutoPorCodigo("P002");
        }

        static void AdicionarProduto(string codigo, string nome, double preco, int quantidade)
        {
            Produto novoProduto = new Produto(codigo, nome, preco, quantidade);
            listaProdutos.Add(novoProduto);
        }

        static void ExibirTodosProdutos()
        {
            Console.WriteLine("Lista de Produtos:");
            foreach (var produto in listaProdutos)
            {
                Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Preço: {produto.Preco:C}, Quantidade em Estoque: {produto.QuantidadeEmEstoque}");
            }
        }

        static void ConsultarProdutoPorCodigo(string codigo)
        {
            Produto produtoEncontrado = listaProdutos.Find(produto => produto.Codigo == codigo);
            if (produtoEncontrado != null)
            {
                Console.WriteLine($"Produto encontrado - Código: {produtoEncontrado.Codigo}, Nome: {produtoEncontrado.Nome}, Preço: {produtoEncontrado.Preco:C}, Quantidade em Estoque: {produtoEncontrado.QuantidadeEmEstoque}");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
    }
}