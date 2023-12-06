
using Aula04;

ExemploJson exemploJson = new ExemploJson();

WeatherForecast weatherForecast = new WeatherForecast();

weatherForecast.Date = DateTimeOffset.Now;
weatherForecast.TemperatureCelsius = 23;

var objetoConvertidoEmJson = exemploJson.Serializar<WeatherForecast>(weatherForecast);

File.WriteAllText("arquivo.json",objetoConvertidoEmJson.ToString());

string conteudoDeserializado = File.ReadAllText("arquivo.json");

var objetoWeatherForescast = exemploJson.Deserializar<WeatherForecast>(conteudoDeserializado);

Console.ReadKey();
