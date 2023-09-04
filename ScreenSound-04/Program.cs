using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[0].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "blues");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        //LinqFilter.FiltrarMusicasPorAno(musicas, "2003");
        LinqFilter.FiltrarMusicasPorTonalidade(musicas, "C#");

        //var musicasPreferidasDoMarcos = new MusicasPreferidas("Marcos");
        //musicasPreferidasDoMarcos.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoMarcos.AdicionarMusicasFavoritas(musicas[10]);
        //musicasPreferidasDoMarcos.AdicionarMusicasFavoritas(musicas[1467]);
        //musicasPreferidasDoMarcos.AdicionarMusicasFavoritas(musicas[157]);
        //musicasPreferidasDoMarcos.AdicionarMusicasFavoritas(musicas[500]);
        //musicasPreferidasDoMarcos.ExibirMusicasFavoritas();
        //musicasPreferidasDoMarcos.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine("Temos um problema" + ex.Message);
    }
}
