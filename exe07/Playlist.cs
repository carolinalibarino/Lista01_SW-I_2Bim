using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Musica
{
    public string Nome { get; set; }
    public string Autor { get; set; }
    public string Gravadora { get; set; }

    public Musica(string nome, string autor, string gravadora)
    {
        Nome = nome;
        Autor = autor;
        Gravadora = gravadora;
    }
}

public class Playlist
{
    private List<Musica> musicas;
    public string Dono { get; set; }
    private Random random;

    public Playlist(string dono)
    {
        Dono = dono;
        musicas = new List<Musica>();
        random = new Random();
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
        Console.WriteLine($"Música '{musica.Nome}' adicionada à playlist.");
    }

    public void TocarMusica()
    {
        if (musicas.Count == 0)
        {
            Console.WriteLine("A playlist está vazia.");
            return;
        }

        int index = random.Next(musicas.Count);
        Musica musica = musicas[index];
        Console.WriteLine($"Tocando agora: {musica.Nome} - {musica.Autor}");
    }
}
