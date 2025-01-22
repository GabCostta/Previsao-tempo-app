using System.Collections.Generic;

public class ModeloClima
{
    public required InformacoesPrincipais Principal { get; set; }
    public List<CondicoesClimaticas> Condicoes { get; set; } = new List<CondicoesClimaticas>();
}

public class InformacoesPrincipais
{
    public double Temperatura { get; set; }
    public int Umidade { get; set; }
}

public class CondicoesClimaticas
{
    public required string Descricao { get; set; }
}
