namespace Exam2.Models
{
    public class CityDTO
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int CountryId { set; get; }

        public CountryDTO countryDTO { set; get; }
    }
}
