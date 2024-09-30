namespace ExercisesForPractice
{
    public static class Where
    {
        public static IEnumerable<Student> GetScholarshipCandidates(IEnumerable<Student> students)
        {
            return students.Where(x => x.Marks.Count() != 0 ? x.Marks.Average() > 4.6 : false);
        }

        public static IEnumerable<string> GetProperlyIndexedWords(
            IEnumerable<string> words)
        {
            return words.Where((x, y) => int.TryParse(x.Split('.')[0], out var res) && res == y + 1);
        }

        public static IEnumerable<Person> GetMultipleFishOwners_Refactored(
            IEnumerable<Person> people)
        {
            return people.Where(x => x.Pets.Count(x=>x.PetType == PetType.Fish) > 1);
        }

        public static IEnumerable<Person> GetMultipleFishOwners(
            IEnumerable<Person> people)
        {
            var result = new List<Person>();
            foreach (var person in people)
            {
                var count = 0;
                foreach (var pet in person.Pets)
                {
                    if (pet.PetType == PetType.Fish)
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    result.Add(person);
                }
            }
            return result;
        }

        public class Student
        {
            public string Name { get; set; }
            public IEnumerable<int> Marks { get; set; }

            public override string ToString()
            {
                return $"{Name} with marks ({string.Join(", ", Marks)})";
            }
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

            public override string ToString()
            {
                return $"{Name} owns: ({string.Join(", ", Pets)})";
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
                return $"pet's name: {Name}, Type: {PetType}";
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
