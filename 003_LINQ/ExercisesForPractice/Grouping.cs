namespace ExercisesForPractice
{
    public static class Grouping
    {
        public static char? GetTheMostFrequentCharacter(string text)
        {
            text = text.ToLower();
            return text == string.Empty ?
                null :
                text.First(z => text.Count(t => t == z) == text.Max(x => text.Count(y => y == x)));

        }
        public static PetType? FindTheHeaviestPetType(IEnumerable<Pet> pets)
        {
            return pets.Count() == 0 ?
                null :
                pets.GroupBy(x => x.PetType).OrderBy(x => x.Average(y => y.Weight)).Last().Key;
        }

        public static IEnumerable<string> CountPets_Refactored(string petsData)
        {
            return
                string.IsNullOrEmpty(petsData) ?
                Enumerable.Empty<string>() :
                petsData.Split(',').GroupBy(x => x).Select(x => $"{x.Key}:{x.Count()}");
        }

        public static IEnumerable<string> CountPets(string petsData)
        {
            if (string.IsNullOrEmpty(petsData))
            {
                return new string[0];
            }
            var pets = petsData.Split(',');
            var petsCountsDictionary = new Dictionary<string, int>();
            foreach (var pet in pets)
            {
                if (!petsCountsDictionary.ContainsKey(pet))
                {
                    petsCountsDictionary[pet] = 0;
                }
                petsCountsDictionary[pet]++;
            }
            var result = new List<string>();
            foreach (var petCount in petsCountsDictionary)
            {
                result.Add($"{petCount.Key}:{petCount.Value}");
            }
            return result;
        }

        public class Pet
        {
            public string Name { get; }
            public PetType PetType { get; }
            public float Weight { get; }

            public Pet(string name, PetType petType, float weight)
            {
                Name = name;
                PetType = petType;
                Weight = weight;
            }

            public override string ToString()
            {
                return $"Name: {Name}, Type: {PetType}, Weight: {Weight}";
            }
        }

        public enum PetType
        {
            Cat,
            Dog,
            Fish
        }
    }
}
