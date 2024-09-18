namespace Task_01
{
    public class Visa
    {
        internal int Id { get; private set; }
        public string Country { get; private set; }
        public DateOnly StartingDate { get; private set; }
        public DateTime EndingDate { get; private set; }

        internal Visa(int id, string country, DateOnly startingDate, DateTime endingDate)
        {
            Id = id;
            Country = country;
            StartingDate = startingDate;
            EndingDate = endingDate;
        }
    }
}