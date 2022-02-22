using Question2.Models;
using Question2.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2.Repository.Interfaces
{
    public interface ICountryRepository : IBaseRepository<Country>
    {
        Task<CountryModel> GetCountry(string number);
    }
}
