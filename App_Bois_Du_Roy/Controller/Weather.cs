using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenWeatherMap.Standard;
using OpenWeatherMap.Standard.Models;

using System.Net.Http;
using System.Net;
using System.Windows.Forms;

namespace App_Bois_Du_Roy.Controller
{
  
    public class WeatherService
    {
        private const string API_KEY = "0a5f4637e70811b291a9c040735f596e";

        public string GetMeteoInfo(string ville)
        {
            string url = $"http://api.openweathermap.org/data/2.5/weather?q={ville}&appid={API_KEY}&units=metric";
            string response = "";
            using (var client = new WebClient())
            {
                try
                {
                    response = client.DownloadString(url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur de connexion: {ex.Message}");
                }
            }
            return response;
        }
    }
}