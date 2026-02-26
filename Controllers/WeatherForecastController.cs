using Microsoft.AspNetCore.Mvc;

namespace DockerWepAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //private static readonly string[] Summaries =
        //[
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //];
        private static readonly string[] Summaries =
     [
         "This", "is", "webapi ", "deployed ", "using ", "docker", "image", "container", "ACR", ""
     ];

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(0, 9).Select(index => new WeatherForecast
            {
                //Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                //TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[index]
            })
            .ToArray();
        }
    }
}
