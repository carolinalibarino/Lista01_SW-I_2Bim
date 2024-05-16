namespace exe10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as informações do animal:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Espécie: ");
            string especie = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Som: ");
            string som = Console.ReadLine();

            Animal animal = new Animal(nome, especie, idade, som);

            Console.WriteLine("\nInformações do animal:");
            Console.WriteLine($"Nome: {animal.Nome}");
            Console.WriteLine($"Espécie: {animal.Especie}");
            Console.WriteLine($"Idade: {animal.Idade}");

            animal.EmitirSom();
        }
    }
}