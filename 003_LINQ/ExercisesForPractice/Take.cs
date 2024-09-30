namespace ExercisesForPractice
{
    public static class Take
    {
        public static IEnumerable<int> TakeSome(IEnumerable<int> numbers)
        {
            return numbers.Count() <= 10 ? numbers.Take(Math.Min(3, numbers.Count())) : numbers.Count() < 100 ? numbers.Take(30) : numbers;
        }

        public static IEnumerable<Pet> GetGivenPercentOfHeaviestPets(
            IEnumerable<Pet> pets, int percent)
        {
            return pets.OrderBy(x => -x.Weight).Take((percent * pets.Count()) / 100);
        }

        public static IEnumerable<DateTime> GetDatesBeforeXXCentury_Refactored(
            IEnumerable<DateTime> dates)
        {
            return dates.TakeWhile(x => x.Year < 1901);
        }

        public static IEnumerable<DateTime> GetDatesBeforeXXCentury(
            IEnumerable<DateTime> dates)
        {
            var result = new List<DateTime>();
            foreach (var date in dates)
            {
                if (date.Year < 1901)
                {
                    result.Add(date);
                }
                else
                {
                    break;
                }
            }
            return result;
        }

        public class Pet
        {
            public string Name { get; }
            public float Weight { get; }

            public Pet(string name, float weight)
            {
                Name = name;
                Weight = weight;
            }

            public override string ToString()
            {
                return $" Name: {Name}, Weight: {Weight}";
            }
        }
    }
}
