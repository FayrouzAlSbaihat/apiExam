using Exam2.data;
using Exam2.Models;
using Exam2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exam2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CityController : ControllerBase
    {
        ICityService cityService;
        public void NewCity(CityDTO cityDTO)
        {
           cityService.AddCity(cityDTO);
        }

        [HttpGet]
        [Route("CityList")]
        public List<CityDTO> CityList()
        {
            return cityService.CityList();
        }


    }
}
