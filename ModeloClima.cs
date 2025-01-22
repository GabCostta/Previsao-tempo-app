using System.Collections.Generic;

public class ModeloClima
{
    public InformacoesPrincipais Main { get; set; } = new InformacoesPrincipais();
    public List<CondicoesClimaticas> Weather { get; set; } = new List<CondicoesClimaticas>();
}

public class InformacoesPrincipais
{
    public double Temp { get; set; }
    public int Humidity { get; set; }
}

public class CondicoesClimaticas
{
    public string Description { get; set; } = string.Empty;
}
