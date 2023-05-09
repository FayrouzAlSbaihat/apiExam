using Exam2.Models;

namespace Exam2.Services
{
    public interface ICityService
    {
        public void AddCity(CityDTO cityDTO);
        public List<CityDTO> CityList();
    }
}
