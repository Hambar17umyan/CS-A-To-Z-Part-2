using System.Text;

namespace Task_01
{
    public class Passport
    {
        public Passport(string name, string surname, DateOnly dateOfBirth)
        {
            ID = GenerateID();
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;

            Visas = new List<Visa>();
            EnteringCountryStamp = new List<LeavingCountryStamp>();
            LeavingCountryStamps = new List<EnteringCountryStamp>();
        }

        private string GenerateID()
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.Append(
                    (char)random.Next('0', '9'));
            }
            return sb.ToString();
        }

        public string ID { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public DateOnly DateOfBirth { get; private set; }
        public List<Visa> Visas { get; private set; }
        public List<LeavingCountryStamp> EnteringCountryStamp { get; private set; }
        public List<EnteringCountryStamp> LeavingCountryStamps { get; private set; }
    }
}