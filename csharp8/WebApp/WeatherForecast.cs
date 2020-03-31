using System;

namespace WebApp
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public int ThreadId { get; set; }

        public WeatherForecast Modify(Action<WeatherForecast> modify)
        {
            modify(this);
            return this;
        }
    }
}
