using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace christian_test.Controllers
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
//  public DateTime Date { get; set; }

//         public int TemperatureC { get; set; }

//         public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

//         public string Summary { get; set; }
        public List<christian_test.WeatherForecast> _records = new List<christian_test.WeatherForecast>(){
            new christian_test.WeatherForecast(){
                Date = DateTime.Now,
                TemperatureC = 12,
                TemperatureF = -12,
                Summary = "testiong"
            },
            new christian_test.WeatherForecast(){
                Date = DateTime.Now,
                TemperatureC = 52,
                TemperatureF = -11,
                Summary = "tawwwww"
            },
        };

        [HttpGet]
        public IEnumerable<christian_test.WeatherForecast> Get()
        {
           
            return _records.ToArray();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] christian_test.WeatherForecast body){
            _records.Add(body);
            return Ok(_records);
        }
    }

    
}
