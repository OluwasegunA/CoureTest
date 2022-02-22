using Question2.DataContext;
using Question2.Models;
using Question2.Models.ViewModel;
using Question2.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Question2.Repository
{
    public class CountryDetailsRepository : BaseRepository<CountryDetails>, ICountryDetailsRepository
    {
        public CountryDetailsRepository(Context context) : base(context)
        {

        }
    }
}