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
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(Context context) : base(context)
        {

        }

        public async Task<CountryModel> GetCountry(string number){
            var request = Convert.ToInt32(number.Substring(0,3));
            var result = await _context.Countries
                                .Where(country => country.CountryCode == request)
                                .Select(coun =>  new CountryModel(){
                                    number = number,
                                    country = getCountrs(coun.Id).Result
                                }).FirstOrDefaultAsync();
            return result;
        }

        public async Task<Countries> getCountrs(int countryId){
            var counDetails = await _context.Countries
                                .Where(country => country.Id == countryId)
                                .Select(coun =>  new Countries(){
                                    name = coun.Name, 
                                    countryCode = coun.CountryCode.ToString(),
                                    countryIso = coun.CountryIso,
                                    countryDetails = getCountryDetails(coun.Id).Result
                                }).FirstOrDefaultAsync();

            return counDetails;
        }

        public async Task<List<Details>> getCountryDetails(int countryId){
            var counDetails = await _context.CountryDetails
                                .Where(country => country.CountryId == countryId)
                                .Select(coun =>  new Details(){
                                    countryOperator = coun.Operator,
                                    operatorCode = coun.OperatorCode
                                }).ToListAsync();

            return counDetails;
        }
    }
}
