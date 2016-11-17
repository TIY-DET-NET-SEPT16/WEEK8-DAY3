using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace WeatherAPIApp.Models
{
    public class WeatherClass
    {
        public object GetCurrentWeather()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Detroit&APPID=23b788bee2f442d46daf6f38eb174d06&units=imperial";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<object>(content);

            return jsonContent;
        }
    }
}