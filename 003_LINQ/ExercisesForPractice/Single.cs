namespace ExercisesForPractice
{
    public static class Single
    {
        public static string GetTheOnlyUpperCaseWord(IEnumerable<string> words)
        {
            if (words.Where(x => x.All(y => y >= 'A' && y <= 'Z')).Count() > 0)
                return words.Single(x => x.All(y => y >= 'A' && y <= 'Z'));
#pragma warning disable CS8603 
            return null;
#pragma warning restore CS8603 
        }

        public static IEnumerable<int> GetSingleElementCollection(
            IEnumerable<IEnumerable<int>> numberCollections)
        {
            return numberCollections.Single(x => x.Count() == 1);
        }

        public static DateTime? GetSingleDay_Refactored(
            IEnumerable<DateTime> dates, DayOfWeek dayOfWeek)
        {
            try
            {
                return dates.Single(x => x.DayOfWeek == dayOfWeek);
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }

        public static DateTime? GetSingleDay(
            IEnumerable<DateTime> dates, DayOfWeek dayOfWeek)
        {
            var count = 0;
            DateTime? result = null;
            foreach (var date in dates)
            {
                if (date.DayOfWeek == dayOfWeek)
                {
                    result = date;
                    count++;
                }
            }
            if (count == 1)
            {
                return result;
            }
            return null;
        }

        public enum PetType
        {
            Cat,
            Dog,
            Fish
        }

        public class Pet
        {
            public int Id { get; }
            public string Name { get; }
            public PetType PetType { get; }
            public float Weight { get; }

            public Pet(int id, string name, PetType petType, float weight)
            {
                Id = id;
                Name = name;
                PetType = petType;
                Weight = weight;
            }

            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}, Type: {PetType}, Weight: {Weight}";
            }
        }
    }
}
