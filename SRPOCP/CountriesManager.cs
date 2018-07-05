using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json;

namespace srp.SRPOCP
{
    class CountriesManager
    {
        private HttpClient http;
        private Country[] countries;

        public CountriesManager() => http = new HttpClient();

        public async Task<Country[]> GetCountries()
        {
            if (countries != null)
            {
                return countries;
            }
            else
            {
                await GetAll();
                return countries;
            }
        }

        public async Task<Country[]> GetEuropeanCountries()
        {
            if (countries != null)
            {
                return FilterCountries("Europe");
            }
            else
            {
                await GetAll();
                return await GetEuropeanCountries();
            }
        }

        private Country[] FilterCountries(string filter)
        {
            List<Country> filterCountries = new List<Country>();
            countries.ToList().ForEach(x =>
            {
                if (string.Compare(x.Region, filter) > 0)
                {
                    filterCountries.Add(x);
                }
            });
            return filterCountries.ToArray();
        }

        public async Task<Country[]> GetAsianCountries()
        {
            if (countries != null)
            {
                return FilterCountries("Asia");
            }
            else
            {
                await GetAll();
                return await GetEuropeanCountries();
            }
        }

        private async Task GetAll()
        {
            HttpResponseMessage response = await http.GetAsync("https://restcountries.eu/rest/v2/all");
            if (ErrorHandler.HandleResponse(response.StatusCode))
            {
                var content = await response.Content.ReadAsStringAsync();
                countries = JsonConvert.DeserializeObject<Country[]>(content);
            }
        }
    }
}