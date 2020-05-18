using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MVC.Contract.Contract;
using MVC.Contract.Model;
using MVCAppWithRepositoryPattern.Models;

namespace MVCAppWithRepositoryPattern.Controllers
{
    public class HomeController : Controller
    {
        public readonly IQueryCountries _queryCountries;
        private readonly IMapper _mapper;
        public HomeController(IQueryCountries queryCountries, IMapper mapper)
        {
            _queryCountries = queryCountries;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var queryCountries = await _queryCountries.QueryCountries(new QueryCountries.Request { });

            var result = _mapper.Map<List<CountryViewModel>>(queryCountries.Countries);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> FindCountryByName(string filterName)
        {
            var queryCountries = await _queryCountries.QueryCountries(new QueryCountries.Request
            {
                FilterCountryByName = filterName
            });

            var result = _mapper.Map<List<CountryViewModel>>(queryCountries.Countries);
            return View("Index", result);
        }

        //public List<CountryViewModel> ManualAutoMapper(QueryCountries.Response queryCountries)
        //{
        //    var response = queryCountries.Countries.Select(x => new CountryViewModel
        //    {
        //        Name = x.Name,
        //        NativeName = x.NativeName,
        //        Capital = x.Capital,
        //        Region = x.Region,
        //        Subregion = x.Subregion,
        //        Population = x.Population
        //    }).ToList();
        //    return response;
        //}
    }
}
