namespace ExercisesForPractice
{
    public static class All
    {

        public static bool AreAllNumbersDivisibleBy10(int[] numbers)
        {
            return numbers.All(x => x % 10 == 0);
        }

        public static bool AreAllPetsOfTheSameType(IEnumerable<Pet> pets)
        {
            if(pets.Count() == 0) 
                return true;
            return pets.All(x => x.PetType == pets.First().PetType);
        }

        public static bool AreAllWordsOfTheSameLength_Refactored(List<string> words)
        {
            if(words.Count() == 0)
                return true;
            return words.All(x => x.Length == words.First().Length);
        }

        public static bool AreAllWordsOfTheSameLength(List<string> words)
        {
            if (words.Count == 0 || words.Count == 1)
            {
                return true;
            }
            var length0 = words[0].Length;
            for (int i = 1; i < words.Count; ++i)
            {
                if (words[i].Length != length0)
                {
                    return false;
                }
            }
            return true;
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