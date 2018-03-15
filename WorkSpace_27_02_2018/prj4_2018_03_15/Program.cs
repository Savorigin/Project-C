using System;
using System.Net;
using System.Threading;
using System.Xml;

namespace prj_2018_03_15_Weather
{
    class Program
    {
        static WeatherInfo GenerateWeather(string city)
        {

            string weburl = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&mode=xml&APPID=26003d0b1fe0ef7825c6ca08f0e159fe";

            var xml = new WebClient().DownloadString(new Uri(weburl));

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            string szTemp = doc.DocumentElement.SelectSingleNode("temperature").Attributes["value"].Value;
            string szTempMin = doc.DocumentElement.SelectSingleNode("temperature").Attributes["min"].Value;
            string szTempMax = doc.DocumentElement.SelectSingleNode("temperature").Attributes["max"].Value;

            string szHum = doc.DocumentElement.SelectSingleNode("humidity").Attributes["value"].Value;
            string szPres = doc.DocumentElement.SelectSingleNode("pressure").Attributes["value"].Value;
            double temp = double.Parse(szTemp) - 273.16;
            double hum = double.Parse(szHum);
            double pres = double.Parse(szPres);
            //    Console.WriteLine(city + "=" + temp.ToString("N2") + " Celcius , min = " + (double.Parse(szTempMin) - 273.16) + ", max= " + (double.Parse(szTempMax) - 273.16));
            return new WeatherInfo { Temp = temp, Hum = hum, Pres = pres };
        }
        static void ClassicWeather()
        {
            WeatherData KyivWeather = new WeatherData();
            WeatherData LvivWeather = new WeatherData();
            CurrentDisplay curDisplay = new CurrentDisplay(KyivWeather);
            LvivWeather.RegisterObs(curDisplay);
            new ForecastDisplay(LvivWeather);
            LvivWeather.RegisterObs(new FormDisplay());
            for (int i = 0; i < 30; i++)
            {
                KyivWeather.SetMeasurement(GenerateWeather("Kyiv"));
                LvivWeather.SetMeasurement(GenerateWeather("Lviv"));
                Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            WeatherDataEvent weatherOdessa = new WeatherDataEvent();
            weatherOdessa.update += new CurrentDisplay().Update;
            weatherOdessa.update += new CurrentDisplay().Update;
            for (int i = 0; i < 30; i++)
            {
                weatherOdessa.OnUpdate(GenerateWeather("Kyiv"));
                Thread.Sleep(100);
            }
        }
    }
}
