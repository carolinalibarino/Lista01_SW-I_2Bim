namespace exe07
{
    class Program
    {
        static void Main(string[] args)
        {
            Playlist minhaPlaylist = new Playlist("João");

            Musica musica1 = new Musica("Imagine", "John Lennon", "Apple Records");
            Musica musica2 = new Musica("Bohemian Rhapsody", "Queen", "EMI");
            Musica musica3 = new Musica("Hotel California", "Eagles", "Asylum Records");

            minhaPlaylist.AdicionarMusica(musica1);
            minhaPlaylist.AdicionarMusica(musica2);
            minhaPlaylist.AdicionarMusica(musica3);

            Console.WriteLine("Tocando músicas aleatoriamente:");
            minhaPlaylist.TocarMusica();
            minhaPlaylist.TocarMusica();
            minhaPlaylist.TocarMusica();
        }
    }
}
