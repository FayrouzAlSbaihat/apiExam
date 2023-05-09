namespace Exam2.data
{
    public class city
    {
        public int Id {set; get; }
        public string Name { set; get; }
        public int CountryId { set; get; }

        public Country country { set; get; }

    }
}
