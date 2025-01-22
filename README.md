# Aplicativo de Previsão do Tempo

Este é um aplicativo de console em C# que consulta a previsão do tempo para uma cidade específica utilizando a API do OpenWeatherMap.

## Funcionalidades

- Consulta a previsão do tempo atual para uma cidade.
- Exibe a temperatura, condição climática e umidade.
- Tradução das condições climáticas para o português.

## Pré-requisitos

- .NET 8.0 SDK ou superior
- Chave de API do OpenWeatherMap

## Configuração

1. Clone este repositório para o seu ambiente local:
    ```sh
    git clone https://github.com/seu-usuario/Previsao-tempo-app.git
    cd Previsao-tempo-app
    ```

2. Abra o arquivo  e substitua a variável  pela sua chave de API do OpenWeatherMap:
    ```csharp
    private readonly string chaveApi = "sua-chave-api";
    ```

3. Restaure as dependências do projeto:
    ```sh
    dotnet restore
    ```

## Executando o Aplicativo

Para executar o aplicativo, utilize o seguinte comando:
```sh
dotnet run