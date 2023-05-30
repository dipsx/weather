using RestSharp;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace Weather_API.Controllers {

    public class WeatherController : ApiController {
        public async Task<CityTemperature> GetCityWithMinTemperature(CancellationToken cancellationToken) {
            var restClient = new RestClient("https://goweather.herokuapp.com");

            var cities = new[] { "Toronto", "Vancouver", "Calgary" };

            var tasks = cities.Select(city => FetchCityTemperature(restClient, city, cancellationToken));

            var results = await Task.WhenAll(tasks);

            var cityWithMinTemperature = results
                .Where(x => x != null)
                .Aggregate((minTempResult, nextResult) =>
                    nextResult.Temperature < minTempResult.Temperature ? nextResult : minTempResult
                );

            return cityWithMinTemperature;
        }

        private async Task<CityTemperature> FetchCityTemperature(RestClient restClient, string city, CancellationToken cancellationToken) {
            try {
                var request = new RestRequest($"weather/{city}");

                var weather = await restClient.GetAsync<WeatherHerokuappResponse>(request, cancellationToken);
                if (weather != null && !string.IsNullOrWhiteSpace(weather.Temperature)) {
                    var temperatureStr = weather.Temperature.Split(' ').First();
                    if (int.TryParse(temperatureStr, out var temperature)) {
                        return new CityTemperature {
                            City = city,
                            Temperature = temperature,
                        };
                    } else {
                        Console.WriteLine($"Unable to parse temperature for city: {city}");
                    }
                } else {
                    Console.WriteLine($"No weather information received for city: {city}");
                }
            } catch (Exception ex) {
                Console.WriteLine($"Exception occurred while fetching weather for city: {city}. Exception: {ex.Message}");
            }

            return null;
        }

    }

    public class CityTemperature {
        public string City { get; set; }
        public int Temperature { get; set; }
    }

    public class WeatherHerokuappResponse {
        public string Temperature { get; set; }
    }
}
