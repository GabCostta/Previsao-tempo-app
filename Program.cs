class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao Aplicativo de Previsão do Tempo!");
        Console.Write("Digite o nome da cidade: ");
        string? cidade = Console.ReadLine();

        if (string.IsNullOrEmpty(cidade))
        {
            Console.WriteLine("O nome da cidade não pode estar vazio.");
            return;
        }

        var servicoClima = new ServicoClima();
        var clima = await servicoClima.ObterClimaAsync(cidade);

        if (clima != null)
        {
            Console.WriteLine($"\nClima em {cidade}:");
            Console.WriteLine($"Temperatura: {clima.Main.Temp}°C");
            Console.WriteLine($"Condição: {TraduzirCondicao(clima.Weather[0].Description)}");
            Console.WriteLine($"Umidade: {clima.Main.Humidity}%");
        }
        else
        {
            Console.WriteLine("Não foi possível obter a previsão do tempo. Verifique a cidade ou a conexão.");
        }
    }

    static string TraduzirCondicao(string descricao)
    {
        var traducoes = new Dictionary<string, string>
        {
            { "clear sky", "céu limpo" },
            { "few clouds", "poucas nuvens" },
            { "scattered clouds", "nuvens dispersas" },
            { "broken clouds", "nuvens quebradas" },
            { "shower rain", "chuva fraca" },
            { "rain", "chuva" },
            { "thunderstorm", "trovoada" },
            { "snow", "neve" },
            { "mist", "névoa" },
            { "overcast clouds", "nublado" },
            { "moderate rain", "chuva moderada" }
        };

        // Retorna a tradução ou o texto original caso não haja tradução
        return traducoes.ContainsKey(descricao) ? traducoes[descricao] : descricao;
    }
}
