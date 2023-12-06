using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Aula04
{
    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string? Summary { get; set; }
    }

    public class ExemploJson
    {
        public T Deserializar<T>(string content)
        {
            T objeto = JsonSerializer.Deserialize<T>(content);
            return objeto;
        }

        public string Serializar<T>(T t)
        {
            return JsonSerializer.Serialize(t);
        }
    }
}
