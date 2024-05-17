namespace exe11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Carro carro1 = new Carro("Fusca", 1972);
                carro1.Acelerar();
                carro1.Acelerar();
                carro1.Frear();
                carro1.Frear();
                carro1.Frear();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
