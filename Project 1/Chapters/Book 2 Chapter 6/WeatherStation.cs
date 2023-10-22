using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Chapters.Book_2_Chapter_6
{
    public class WeatherStation
    {
        public delegate void WeatherEvent();

        public event WeatherEvent Normal;
        public event WeatherEvent Raining;
        public event WeatherEvent Snowing;
        public event WeatherEvent Lightning;
        public event WeatherEvent Tornado;

        private Random randGenerator = new Random();
        private int ReadWeatherSensor() { return randGenerator.Next(5); }

        public void MonitorTheWeather()
        {
            // Change the weather :)
            int sensorValue = ReadWeatherSensor();

            switch (sensorValue)
            {
                case 0:
                    { this.Normal(); break; }
                case 1:
                    { this.Raining(); break; }
                case 2:
                    { this.Snowing(); break; }
                case 3:
                    { this.Lightning(); break; }
                case 4:
                    { this.Tornado(); break; }
            }
        }
    }
}
