namespace exe01
{
    internal class Program
    {
        class Programa
        {
            static void Main(string[] args)
            {
                Produto produto1 = new Produto("Camiseta", 25.00m, 50);
                Console.WriteLine($"Produto: {produto1.Nome}, Preço: R${produto1.Preco}, Quantidade em estoque: {produto1.Quantidade}");

                produto1.AdicionarItem(10);
                Console.WriteLine($"Quantidade após adicionar: {produto1.Quantidade}");

                produto1.RemoverItem(5);
                Console.WriteLine($"Quantidade após remover: {produto1.Quantidade}");
            }
        }
    }
}