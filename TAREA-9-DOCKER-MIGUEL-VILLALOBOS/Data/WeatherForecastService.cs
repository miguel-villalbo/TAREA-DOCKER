namespace Tarea_9_Docker.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public async Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate)
        {
            var forecasts = new List<WeatherForecast>();

            for (int index = 1; index <= 5; index++)
            {
                var forecast = new WeatherForecast
                {
                    Date = startDate.AddDays(index),
                    TemperatureC = GenerateRandomTemperature(),
                    Summary = GetRandomSummary()
                };

                forecasts.Add(forecast);
            }

            return forecasts.ToArray();
        }

        private int GenerateRandomTemperature()
        {
            Random random = new Random();
            return random.Next(-20, 55);
        }

        private string GetRandomSummary()
        {
            Random random = new Random();
            int index = random.Next(Summaries.Length);
            return Summaries[index];
        }
    }
}
