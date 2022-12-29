using System.Formats.Asn1;
using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json;

namespace SampleMySql.Models
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
