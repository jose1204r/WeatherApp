using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Weatherapp
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {

            
            var client = new HttpClient();

            Console.WriteLine("*************Wheather APP***************");
            
            Console.WriteLine("PLEASE ENTER CITY TO SEE CURRENT WEATHER :");
                var cityname = Console.ReadLine().ToUpper(); ;
                Console.Clear();
                Console.WriteLine("Lodding Data");
                for (int i = 0; i < 7; i++)
                {   
                   
                    Console.Write(".");
                    Thread.Sleep(1000);

                }
                Console.Clear();

                var apiurl = $"http://api.weatherapi.com/v1/current.json?key=3f1fca3a394e404e9fd175827221712&q={cityname}";

            var response = client.GetStringAsync(apiurl).Result;

            var wheatherqoute = JObject.Parse(response).GetValue("current").ToString();
            Console.WriteLine($"City :{cityname}  {wheatherqoute}");
                Console.WriteLine("DO YOU LIKE TO ENTER ANTOHER CITY YES/NO");
                var usersleections = Console.ReadLine();

                if (usersleections.ToLower() == "no") 
                {
                    Console.Clear();
                  Environment.Exit(0);
                
                }
                Console.Clear();

               
            } while (true);
            
        }
    }
}