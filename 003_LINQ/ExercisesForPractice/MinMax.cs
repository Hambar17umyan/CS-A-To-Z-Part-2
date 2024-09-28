namespace ExercisesForPractice
{
    public static class MinMax
    {
        public static int? LengthOfTheShortestWord(IEnumerable<string> words)
        {
            return words.Count() == 0 ? null : words.Min(word => word.Length);
        }
        public static int CountOfLargestNumbers(IEnumerable<int> numbers)
        {
            return numbers.Count() == 0 ? 0 : numbers.Count(x => x == numbers.Max());
        }

        public static int CountOfDogsOfTheOwnerWithMostDogs_Refactored(
            IEnumerable<Person> owners)
        {
            return owners.Max(x => x.Pets.Count(y => y.PetType == PetType.Dog));
        }

        public static int CountOfDogsOfTheOwnerWithMostDogs(IEnumerable<Person> owners)
        {
            var maxDogCount = 0;
            foreach (var owner in owners)
            {
                var dogsCount = 0;
                foreach (var pet in owner.Pets)
                {
                    if (pet.PetType == PetType.Dog)
                    {
                        dogsCount++;
                    }
                }
                if (dogsCount > maxDogCount)
                {
                    maxDogCount = dogsCount;
                }
            }
            return maxDogCount;
        }

        public class Person
        {
            public int Id { get; }
            public string Name { get; }
            public IEnumerable<Pet> Pets;

            public Person(int id, string name, IEnumerable<Pet> pets)
            {
                Id = id;
                Name = name;
                Pets = pets;
            }
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
                return $"Id: {Id}, Name: {Name}, Type: {PetType}";
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
