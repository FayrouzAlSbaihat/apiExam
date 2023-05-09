using Exam2.data;
using Exam2.Models;

namespace Exam2.Services
{
    public class CountryService: ICountryService
    {
        EContext Context;
        public CountryService(EContext _context)
        {
            Context = _context;
        }

        public void AddCountry(CountryDTO countryDTO)
        {
            Country country = new Country()
            {
                Id = countryDTO.Id,
                Name = countryDTO.Name,
                code=countryDTO.code
               
            };
            Context.Add(country);
            Context.SaveChanges();

        }


        public List<CountryDTO> CountryList()
        {
            List<Country> countries=Context.countries.ToList();
            List<CountryDTO> licountry = new List<CountryDTO>();
            foreach(Country country in countries)
            {
                CountryDTO countryDTO = new CountryDTO()
                {
                    Id = country.Id,
                    Name = country.Name,
                    code = country.code
                };
                    licountry.Add(countryDTO);
                
            }
            return licountry;
            
        }

        public Country getcountry(int id)
        {
            Country country = Context.countries.Find(id);
            return country;
            
        }

    }
}
