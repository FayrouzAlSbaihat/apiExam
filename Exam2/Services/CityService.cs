using Exam2.data;
using Exam2.Models;

namespace Exam2.Services
{
    public class CityService:ICityService
    {
        EContext Context;
        ICountryService countryService;
        public CityService(EContext _context, ICountryService _countryService)
        {
            Context = _context;
            countryService = _countryService;
        }

        public void AddCity(CityDTO cityDTO)
        { 
            city city =new city() { 
            Id = cityDTO.Id,
            Name = cityDTO.Name,
            CountryId=cityDTO.CountryId
        }; 
            Context.Add(city);
            Context.SaveChanges();
            
        }

            public List<CityDTO> CityList()
            {
                List<city> cities = Context.cities.ToList();

                List<CityDTO> licity = new List<CityDTO>();
                foreach (city c in cities)
                {
                CityDTO cityDTO = new CityDTO()
                {
                    Id = c.Id,
                    Name = c.Name,
                    CountryId = c.CountryId
                    };
                licity.Add(cityDTO);

                }
                return licity;

            }
    }
}

