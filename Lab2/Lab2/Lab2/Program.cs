using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            string call = "https://api.openweathermap.org/data/3.0/onecall?lat=33.44&lon=-94.04&exclude=hourly,daily&appid=9901bac8e051c8fb0b5989c9c61f5fde";
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(call);
           

            Application.Run(new Form1(response));
        }
    }
}
