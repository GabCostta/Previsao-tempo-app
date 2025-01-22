using System.Collections.Generic;

public class ModeloClimaDetalhado
{
    public double Lat { get; set; }
    public double Lon { get; set; }
    public string Timezone { get; set; }
    public int TimezoneOffset { get; set; }
    public ClimaAtual Current { get; set; }
    public List<PrevisaoDiaria> Daily { get; set; }
    public List<Alerta> Alerts { get; set; }
}

public class ClimaAtual
{
    public long Dt { get; set; }
    public double Temp { get; set; }
    public int Humidity { get; set; }
    public List<CondicoesClimaticas> Weather { get; set; }
}

public class PrevisaoDiaria
{
    public long Dt { get; set; }
    public Temperatura Temp { get; set; }
    public int Humidity { get; set; }
    public List<CondicoesClimaticas> Weather { get; set; }
}

public class Temperatura
{
    public double Day { get; set; }
    public double Min { get; set; }
    public double Max { get; set; }
    public double Night { get; set; }
}

public class Alerta
{
    public string SenderName { get; set; }
    public string Event { get; set; }
    public string Description { get; set; }
}
