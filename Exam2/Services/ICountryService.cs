using Exam2.Models;

namespace Exam2.Services
{
    public interface ICountryService
    {
        public void AddCountry(CountryDTO countryDTO);
        public List<CountryDTO> CountryList();
        public Country getcountry(int id);
    }
}
