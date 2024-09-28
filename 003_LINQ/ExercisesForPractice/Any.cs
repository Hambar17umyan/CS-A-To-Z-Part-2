namespace ExercisesForPractice
{
    public class Any
    {

        public static bool IsAnyNumberNegative(IEnumerable<int> numbers)
        {
            return numbers.Any(x => x < 0);
        }

        public static bool AreThereAnyBigCats(IEnumerable<Pet> pets)
        {
            return pets.Any(x => x.PetType == PetType.Cat & x.Weight > 2);
        }

        public static bool AreAllNamesValid_Refactored(string[] names)
        {
            return !names.Any(x => char.IsLower(x[0]) | x.Length < 2 | x.Length > 25);
        }

        public static bool AreAllNamesValid(string[] names)
        {
            foreach (var name in names)
            {
                if (char.IsLower(name[0]))
                {
                    return false;
                }
                if (name.Length < 2)
                {
                    return false;
                }
                if (name.Length > 25)
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