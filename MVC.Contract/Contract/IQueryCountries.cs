using MVC.Contract.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Contract.Contract
{
    public interface IQueryCountries
    {
        Task<QueryCountries.Response> QueryCountries(QueryCountries.Request request);
    }
}
