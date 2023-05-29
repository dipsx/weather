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
Create a REST API to check weather for Toronto, Vancouver and Calgary, and return the coldest city.

Request
```
curl http://localhost:63013/api/weather

```
Response
```json
{
    "city":"Toronto",
    "temperature": "29"
}
```

1. Clone main branch to c:\Interview
2. Open /weather/Weather-API/Weather-API.sln
3. Finish Controllers/WeatherController.cs

## Task 2
Show coldest city in VueJS.

1. Open /weather-ui
2. Finish Vue project


