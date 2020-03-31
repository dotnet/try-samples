using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            var beforeThread = Thread.CurrentThread.ManagedThreadId;
            var forecast = Forecast(new WeatherForecast{ThreadId = beforeThread});
            _ = forecast
                .ContinueWith((t, o) =>
                {
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                }, null, TaskScheduler.Default);

            return await forecast;
        }

        private static async Task<IEnumerable<WeatherForecast>> Forecast(WeatherForecast weatherForecast)
        {
            await Task.Delay(1);
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index =>
            {
                return weatherForecast.Modify(w => w.Date = DateTime.Now.AddDays(index))
                    .Modify(w => w.TemperatureC = rng.Next(-20, 55))
                    .Modify(w => w.Summary = Summaries[rng.Next(Summaries.Length)]);
            }).ToArray();
        }
    }
}
