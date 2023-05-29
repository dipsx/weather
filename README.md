# Weather API

Request 
```
curl https://goweather.herokuapp.com/weather/{city}

//for example
curl https://goweather.herokuapp.com/weather/Toronto
```

Response
```JSON
{  
   "temperature":"29 °C",
   "wind":"20 km/h",
   "description":"Partly cloudy",
   "forecast":[  
      {  
         "day":1,
         "temperature":"27 °C",
         "wind":"12 km/h"
      },
      {  
         "day":2,
         "temperature":"22 °C",
         "wind":"8 km/h"
      }
   ]
}
```


## Task 1
Clone main branch to c:\interview

## Task 2 - ASP.NET API
> Open \Weather-API\Weather-API.sln

> Controllers/WeatherController.cs

Create a REST API to check weather for oronto, Vancouver and Calgary, and return the city with the lowest temperature. 

Request
```
GET http://localhost:63013/api/weather
```
Response
```json
{
    "city":"Toronto",
    "temperature": "29"
}
```


## Task 3 VueJS
> Open \weather-ui

Create a page to show the city with the lowest temperature. (Consuming goweather.herokuapp.com API direct, without calling API created on Task 2)


 

