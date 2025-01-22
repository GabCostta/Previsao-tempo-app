using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao Aplicativo de Previsão do Tempo!");
        Console.Write("Digite o nome da cidade: ");
        string cidade = Console.ReadLine();

        var servicoClima = new ServicoClima();
        var clima = await servicoClima.ObterClimaAsync(cidade);

        if (clima != null)
        {
            Console.WriteLine($"\nClima em {cidade}:");
            Console.WriteLine($"Temperatura: {clima.Principal.Temperatura}°C");
            Console.WriteLine($"Condição: {clima.Condicoes[0].Descricao}");
            Console.WriteLine($"Umidade: {clima.Principal.Umidade}%");
        }
        else
        {
            Console.WriteLine("Não foi possível obter a previsão do tempo. Verifique a cidade ou a conexão.");
        }
    }
}
