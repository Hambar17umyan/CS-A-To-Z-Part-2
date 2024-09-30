namespace ExercisesForPractice
{
    public static class FirstLast
    {
        public static string FindFirstNameInTheCollection(IEnumerable<string> words)
        {
            try
            {
                return words.First(x => x.Count() > 1 && x[0] >= 'A' && x[0] <= 'Z' && x.Skip(1).All(y => y <= 'z' && y >= 'a'));
            }
            catch
            {
                return null;
            }

        }

        public static Person GetYoungest(IEnumerable<Person> people)
        {
            var now = DateTime.Now;
#pragma warning disable CS8603
            return people.OrderBy(x => now - x.DateOfBirth).FirstOrDefault();
#pragma warning restore CS8603 
        }

        public static Person FindOwnerOf_Refactored(Pet pet, IEnumerable<Person> people)
        {
            try
            {
                return people.First(x => x.Pets.Contains(pet));
            }
            catch
            {
                return null;
            }
        }

        public static Person FindOwnerOf(Pet pet, IEnumerable<Person> people)
        {
            foreach (var person in people)
            {
                foreach (var personsPet in person.Pets)
                {
                    if (personsPet == pet)
                    {
                        return person;
                    }
                }
            }
            return null;
        }

        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public IEnumerable<Pet> Pets;
            public DateTime DateOfBirth { get; set; }

            public Person(string name, DateTime dateOfBirth)
            {
                Name = name;
                DateOfBirth = dateOfBirth;
            }

            public Person(int id, string name, IEnumerable<Pet> pets)
            {
                Id = id;
                Name = name;
                Pets = pets;
            }

            public override string ToString()
            {
                return $"Name: {Name}, DateOfBirth: {DateOfBirth}";
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
                return $"Id: {Id}, Name: {Name}, Type: {PetType}, Weight: {Weight}";
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

