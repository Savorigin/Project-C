using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_2018_03_15_Weather
{
    delegate void ObsDel(WeatherInfo weather);
    class WeatherDataEvent
    {
        public event ObsDel updates;
        public void OnUpdate(WeatherInfo weather) {
            if (updates != null) updates(weather);
        }
    }
}
