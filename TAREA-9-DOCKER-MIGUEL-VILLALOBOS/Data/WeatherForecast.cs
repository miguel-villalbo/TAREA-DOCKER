namespace Tarea_9_Docker.Data
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => CalculateFahrenheit(TemperatureC);
        public string? Summary { get; set; }

        public WeatherForecast(DateOnly date, int temperatureC, string? summary)
        {
            Date = date;
            TemperatureC = temperatureC;
            Summary = summary;
        }

        private int CalculateFahrenheit(int celsius)
        {
            const double conversionFactor = 9.0 / 5.0;
            const int fahrenheitBase = 32;
            return (int)(celsius * conversionFactor) + fahrenheitBase;
        }
    }
}
