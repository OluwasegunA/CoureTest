using Question2.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2.Service.Interfaces
{
    public interface ICountryService
    {
        CountryModel getCountry(string number);
        string createCountryAndDetails();
    }
}
