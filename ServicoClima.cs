using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class ServicoClima
{
    private readonly string chaveApi = "SUA_API_KEY"; // Substitua pela sua chave da OpenWeatherMap
    private readonly string urlBase = "https://api.openweathermap.org/data/2.5/weather";

    public async Task<ModeloClima?> ObterClimaAsync(string cidade)
    {
        using var cliente = new HttpClient();
        try
        {
            string url = $"{urlBase}?q={cidade}&appid={chaveApi}&units=metric";
            var resposta = await cliente.GetAsync(url);

            if (resposta.IsSuccessStatusCode)
            {
                var json = await resposta.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ModeloClima>(json);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao acessar a API: {ex.Message}");
        }

        return null;
    }
}
