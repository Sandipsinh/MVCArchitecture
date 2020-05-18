using AutoMapper;
using MVC.Contract.DTO;
using MVC.Contract.Model;
using MVCAppWithRepositoryPattern.Models;


namespace MVCAppWithRepositoryPattern.Mapping
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<CountryDTO, CountryViewModel>();
        }
    }
}
