namespace exe08
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Fabricante fabricante = new Fabricante("Acme Corp", "1234 Rua Principal", "São Paulo");

                Produto produto1 = new Produto("Notebook", fabricante, 2500m);
                Produto produto2 = new Produto("Smartphone", fabricante, 1200m);

                Console.WriteLine($"Produto: {produto1.Nome}, Fabricante: {produto1.Fabricante.Nome}, Preço: {produto1.Preco}");
                Console.WriteLine($"Produto: {produto2.Nome}, Fabricante: {produto2.Fabricante.Nome}, Preço: {produto2.Preco}");

                // Testando a validação
                //Produto produtoInvalido = new Produto("", fabricante, -500m); // Isso vai gerar uma exceção
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
