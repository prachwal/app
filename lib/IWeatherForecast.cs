using System;

namespace lib
{
    public interface IWeatherForecast
    {
        DateTime Date { get; set; }
        string Summary { get; set; }
        int TemperatureC { get; set; }
        int TemperatureF { get; }
    }
}