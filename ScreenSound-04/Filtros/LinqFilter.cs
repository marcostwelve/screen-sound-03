using ScreenSound_04.Modelos;
namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorAno(List<Musica> musicas, string anoDaMusica)
    {
        var anoDeLancamentoMusica = musicas.Where(musica => musica.Ano!.Equals(anoDaMusica)).Select(musica => musica.Nome).ToList();
        Console.WriteLine($"Músicas lançadas em {anoDaMusica}");
        foreach(var musica in anoDeLancamentoMusica)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, string tonalidade)
    {
        var tonalidadeMusicas = musicas.Where(musica => musica.Tonalidade.Equals(tonalidade)).Select(musica => musica.Nome).ToList();
        Console.WriteLine($"Músicas na tonalidade {tonalidade}\n");
        foreach(var musica in tonalidadeMusicas)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
