using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
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
            SynchronizationContext.SetSynchronizationContext(new SynchronizationContext());
            _logger.LogDebug($"Current sync context = {SynchronizationContext.Current}, isNull = {SynchronizationContext.Current == null}");


            var beforeThread = Thread.CurrentThread.ManagedThreadId;

            var continueOnCapturedContext = false;

            var forecastedDays = await Forecast(new WeatherForecast { CapturedInitialThread = beforeThread })
                              .ConfigureAwait(continueOnCapturedContext);

            _logger.LogDebug($"{Thread.CurrentThread.ManagedThreadId} - After completed. ");


            return forecastedDays;
        }

        private async Task<IEnumerable<WeatherForecast>> Forecast(WeatherForecast weatherForecast)
        {
            var uri = new Uri("http://www.google.com");
            var client = new HttpClient {BaseAddress = uri};

            _logger.LogDebug($"{Thread.CurrentThread.ManagedThreadId} - In task, Before await. ");
            _logger.LogDebug($"Get HTTP Response {(await client.GetAsync(uri)).GetHashCode()}");

            _logger.LogDebug($"{Thread.CurrentThread.ManagedThreadId} - In task, After await. ");
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index =>
            {
                return weatherForecast.With(w => w.Date = DateTime.Now.AddDays(index))
                    .With(w => w.TemperatureC = rng.Next(-20, 55))
                    .With(w => w.Summary = Summaries[rng.Next(Summaries.Length)]);
            }).ToArray();
        }
    }
}
