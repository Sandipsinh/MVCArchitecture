using MVC.Contract.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.Contract.Model
{
    public static class QueryCountries
    {
        public class Request
        {
            public string FilterCountryByName { get; set; }
        }
        public class Response
        {
            public List<CountryDTO> Countries { get; set; }
        }
    }
}
