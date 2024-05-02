namespace exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistroDeCompras registro = new RegistroDeCompras();
            Produto produto1 = new Produto("Camiseta", 25.00m, 50);
            Produto produto2 = new Produto("Calça", 50.00m, 30);

            registro.AdicionarCompra(DateTime.Now, produto1, 500.00m);
            registro.AdicionarCompra(DateTime.Now.AddDays(-1), produto2, 1000.00m);

            registro.ListarCompras();
        }
    }
}