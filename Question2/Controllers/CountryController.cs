using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Question2.Models.ViewModel;
using Question2.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegunInterview.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EndPointController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public EndPointController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpPost("modelLoading", Name = nameof(Profile))]
        public ActionResult Profile()
        {

            return Ok(_countryService.createCountryAndDetails());
        }


        [HttpGet("countryDetails/{number}", Name = nameof(GetCountryDetails))]
        public ActionResult<CountryModel> GetCountryDetails(string number)
        {
            var country = _countryService.getCountry(number);

            if(country == null) return NotFound();
            return Ok(country);
        }
    }
}
