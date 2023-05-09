using Exam2.Models;
using Exam2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exam2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        ICountryService countryService;
        CountryController(ICountryService _countryService)
        {
            countryService = _countryService;
        }


        [HttpGet]
        [Route("CountryList")]
        public List<CountryDTO> CountryList()
        {
          return countryService.CountryList();
        }

        [HttpPost]
        [Route("NewCountry")]
        public void NewCountry(CountryDTO countryDTO)
        {
            countryService.AddCountry(countryDTO);
        }
    }
}
