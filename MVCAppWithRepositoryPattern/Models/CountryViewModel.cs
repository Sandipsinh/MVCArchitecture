using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAppWithRepositoryPattern.Models
{
    public class CountryViewModel
    {
        public string Name { get; set; }
        public List<string> TopLevelDomain { get; set; }
        public string Alpha2Code { get; set; }
        public string Dlpha3Code { get; set; }
        public List<string> CallingCodes { get; set; }
        public string Capital { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public string Population { get; set; }
        public List<string> Latlng { get; set; }
        public string NativeName { get; set; }
    }
}
