using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class CurrentWeather
    {
        public List<WeatherInfo> Weather { get; set; }
    }

    public class WeatherInfo
    {
        public string Main { get; set; }
    }
}
