using RestSharp;

namespace StateOfIdaho.UI.Data
{
    public class WeatherForecastService
    {
        private readonly RestClientOptions options = new("https://its-invoice-apps.tapv2-proud-quokka.tapsandbox.com");

        public Task<WeatherForecast[]?> GetForecastAsync(DateTime startDate)
        {
            var client = new RestClient(options);
            var request = new RestRequest("/weatherforecast");
            return client.GetAsync<WeatherForecast[]>(request);
        }
    }
}
