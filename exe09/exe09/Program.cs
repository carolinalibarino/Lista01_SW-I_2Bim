class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Quantos livros você quer adicionar?");
            int numLivros = int.Parse(Console.ReadLine());

            for (int i = 0; i < numLivros; i++)
            {
                Console.WriteLine($"Insira o título do livro {i + 1}:");
                string titulo = Console.ReadLine();

                Console.WriteLine($"Insira o autor do livro {i + 1}:");
                string autor = Console.ReadLine();

                Livro livro = new Livro(titulo, autor);
                Console.WriteLine($"Livro adicionado: {livro.Titulo}, Autor: {livro.Autor}");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro para a quantidade de livros.");
        }
    }
}