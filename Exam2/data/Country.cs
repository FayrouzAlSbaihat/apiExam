namespace Exam2.data
{
    public class Country
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string code { set; get; }

        public List<city> city { set; get; }
    }
}
