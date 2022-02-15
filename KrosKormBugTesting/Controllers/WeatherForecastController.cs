using Kros.KORM;
using Microsoft.AspNetCore.Mvc;

namespace KrosKormBugTesting.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IDatabase _database;

        public WeatherForecastController(IDatabase database)
        {
            _database = database;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return _database.Query<WeatherForecast>().AsEnumerable();
        }
    }
}