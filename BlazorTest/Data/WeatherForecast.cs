namespace BlazorTest.Data
{
    public class WeatherForecast
    {
        // this is a test
        // this is a test
        // this is a test
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}