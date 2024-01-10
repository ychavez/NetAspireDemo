using Frontend.Components.Pages;

namespace Frontend
{
    public class WeatherApiClient(HttpClient _client)
    {
        public async Task<WeatherForecast[]> GetWeatherAsync()
        {
            return await _client
                .GetFromJsonAsync<WeatherForecast[]>("weatherforecast") ?? [];
        }
    }
}
