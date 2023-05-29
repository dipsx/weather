using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Weather_API.Controllers
{
    public class WeatherController : ApiController
    {

        public string Get(string city)
        {
            string url = $"https://goweather.herokuapp.com/weather/{city}";

            RestSharp.RestClient client = new RestSharp.RestClient("https://goweather.herokuapp.com");
            RestSharp.RestRequest request = new RestSharp.RestRequest($"weather/{city}", method: RestSharp.Method.Get);

            var response = client.Execute(request);
            return response.Content;
        }

    }
}
