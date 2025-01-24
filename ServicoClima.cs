using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DotNetEnv; // Para carregar variáveis de ambiente

public class ServicoClima
{
    private readonly string urlBase = "https://api.openweathermap.org/data/2.5/weather";
    private readonly string chaveApi;

    public ServicoClima()
    {
        // Carregando as variáveis de ambiente do arquivo .env
        DotNetEnv.Env.Load();
        chaveApi = Environment.GetEnvironmentVariable("API_KEY") ?? throw new InvalidOperationException("Chave de API não encontrada no arquivo .env");
    }

    public async Task<ModeloClima?> ObterClimaAsync(string cidade)
    {
        using var cliente = new HttpClient();
        try
        {
            // Construindo URL com a cidade fornecida
            string url = $"{urlBase}?q={cidade}&appid={chaveApi}&units=metric";
            var resposta = await cliente.GetAsync(url);

            if (resposta.IsSuccessStatusCode)
            {
                var json = await resposta.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ModeloClima>(json);
            }
            else
            {
                Console.WriteLine($"Erro na resposta da API: {resposta.StatusCode}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao acessar a API: {ex.Message}");
        }

        return null;
    }
}
