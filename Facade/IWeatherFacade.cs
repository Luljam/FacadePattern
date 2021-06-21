using Facade.Entities;
using Facade.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public interface IWeatherFacade
    {
        WeatherFacadeResults GetTempCity(string zipCode);
    }

    public class WeatherFacade : IWeatherFacade
    {
        private readonly ConverterService _converterService;
        private readonly GeoLookupService _geoLookupService;
        private readonly WeatherService _weatherService;

        public WeatherFacade() : this(new ConverterService(), new GeoLookupService(), new WeatherService())
        {

        }

        public WeatherFacade(ConverterService converterService, GeoLookupService geoLookupService, WeatherService weatherService)
        {
            _converterService = converterService;
            _geoLookupService = geoLookupService;
            _weatherService = weatherService;
        }

        public WeatherFacadeResults GetTempCity(string zipCode)
        {
            City city = _geoLookupService.GetCityForZipCode(zipCode);
            State state = _geoLookupService.GetStateForZipCode(zipCode);
            int tempF = _weatherService.GetTempFahrenheit(city, state);
            int tempC = _converterService.ConvertFahrenheitToCelcious(tempF);

            var results = new WeatherFacadeResults
            {
                City = city,
                State = state,
                Fahrenheit = tempF,
                Celsius = tempC
            };

            return results;
        }
    }
}