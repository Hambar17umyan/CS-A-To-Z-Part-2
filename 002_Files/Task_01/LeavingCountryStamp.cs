namespace Task_01
{
    public class LeavingCountryStamp
    {
        public LeavingCountryStamp(int id, string country, DateTime dateTime)
        {
            Id = id;
            Country = country;
            DateTime = dateTime;
        }

        internal int Id { get; private set; }
        public string Country { get; private set; }
        public DateTime DateTime { get; private set; }


    }
}