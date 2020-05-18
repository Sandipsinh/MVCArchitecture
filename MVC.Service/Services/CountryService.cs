using MVC.Contract.Contract;
using MVC.Contract.DTO;
using MVC.Contract.Model;
using MVC.GlobalAPI.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Service.Services
{
    public class CountryService : IQueryCountries
    {
        private readonly HttpClient _client;
        public CountryService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(APIRegistry.BaseURL);
        }

        public async Task<QueryCountries.Response> QueryCountries(QueryCountries.Request request)
        {
            try
            {
                var requestURL = string.IsNullOrEmpty(request.FilterCountryByName) ? APIRegistry.QueryCountries : $"{APIRegistry.QueryFilterCountries}/{request.FilterCountryByName}";
                var queryCountries = await _client.GetAsync(requestURL);
                if (queryCountries.IsSuccessStatusCode)
                {
                    var responseData = await queryCountries.Content.ReadAsStringAsync();
                    var countries = JsonConvert.DeserializeObject<List<CountryDTO>>(responseData);
                    return new QueryCountries.Response
                    {
                        Countries = countries
                    };
                }
                return null;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
