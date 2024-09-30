namespace ExercisesForPractice
{
    public static class ElementAt
    {
        public static bool IsTheNumberAtIndexTheLargest(
            IEnumerable<int> numbers, int index)
        {
            if (index < 0 || index >= numbers.Count())
                return false;
            return numbers.ElementAt(index) == numbers.Max();
        }

        public static string FormatPetDataAtIndex(
            IEnumerable<Pet> pets, int index)
        {
            return (index >= 0 && index < pets.Count() && pets.ElementAt(index) != null) ? $"Pet name: {pets.ElementAt(index).Name}" : $"Pet data is missing for index {index}";
        }

        public static bool IsEmptyAtIndex_Refactored(IEnumerable<string> words, int index)
        {
            return (index >= 0 && index < words.Count()) ? string.IsNullOrEmpty(words.ElementAt(index)) : true;
        }

        public static bool IsEmptyAtIndex(IEnumerable<string> words, int index)
        {
            var array = words.ToArray();
            if (index < 0 || index >= array.Length)
            {
                return true;
            }
            if (string.IsNullOrEmpty(array[index]))
            {
                return true;
            }
            return false;
        }

        public class Pet
        {
            public string Name { get; set; }
        }
    }
}