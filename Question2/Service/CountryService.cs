using AutoMapper;
using Question2.Models;
using Question2.Models.ViewModel;
using Question2.Repository.Interfaces;
using Question2.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2.Service
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        private readonly ICountryDetailsRepository _countryDetailsRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public CountryService(ICountryRepository countryRepository, ICountryDetailsRepository countryDetailsRepository, IMapper mapper, ILogger<CountryService> logger)
        {
            _mapper = mapper;
            _logger = logger;
            _countryRepository = countryRepository;
            _countryDetailsRepository = countryDetailsRepository;
        }

        public CountryModel getCountry(string number)
        {
    
            try{
                var result = _mapper.Map<CountryModel>(_countryRepository.GetCountry(number).Result);

                return result;
            }catch(Exception ex){
                _logger.LogError(ex.Message);
                return null;
            }
        }

        public string createCountryAndDetails(){
            _countryRepository.Create(new Country{CountryCode = 234, Name = "Nigeria", CountryIso = "NG"});
            _countryRepository.Create(new Country{CountryCode = 233, Name = "Ghana", CountryIso = "GH"});
            _countryRepository.Create(new Country{CountryCode = 229, Name = "Benin Republic", CountryIso = "BN"});
            _countryRepository.Create(new Country{CountryCode = 225, Name = "Côte d'Ivoire", CountryIso = "CIV"});
            
            _countryDetailsRepository.Create(new CountryDetails{CountryId = 1, Operator = "MTN Nigeria", OperatorCode = "MTN NG"});
            _countryDetailsRepository.Create(new CountryDetails{CountryId = 1, Operator = "Airtel Nigeria", OperatorCode = "ANG"});
            _countryDetailsRepository.Create(new CountryDetails{CountryId = 1, Operator = "9 Mobile Nigeria", OperatorCode = "ETN"});
            _countryDetailsRepository.Create(new CountryDetails{CountryId = 1, Operator = "Globacom Nigeria", OperatorCode = "GLO NG"});
            _countryDetailsRepository.Create(new CountryDetails{CountryId = 2, Operator = "Vodafone Ghana", OperatorCode = "Vodafone GH"});
            _countryDetailsRepository.Create(new CountryDetails{CountryId = 2, Operator = "MTN Ghana", OperatorCode = "MTN Ghana"});
            _countryDetailsRepository.Create(new CountryDetails{CountryId = 2, Operator = "Tigo Ghana", OperatorCode = "Tigo Ghana"});
            _countryDetailsRepository.Create(new CountryDetails{CountryId = 3, Operator = "MTN Benin", OperatorCode = "MTN Benin"});
            _countryDetailsRepository.Create(new CountryDetails{CountryId = 3, Operator = "Moov Benin", OperatorCode = "Moov Benin"});
            _countryDetailsRepository.Create(new CountryDetails{CountryId = 4, Operator = "MTN Côte d'Ivoire", OperatorCode = "MTN CIV"});
            return "Successful";
        }
    }

}
