namespace ExercisesForPractice
{
    public static class Distinct
    {
        public static bool AreAllUnique<T>(IEnumerable<T> collection)
        {
            return collection.Distinct().Count() == collection.Count();
        }

        public static IEnumerable<T> GetCollectionWithMostDuplicates<T>(
            IEnumerable<IEnumerable<T>> collections)
        {
            if (collections == null || !collections.Any())
                return null;
            return collections.OrderByDescending(x=>x.Count()).OrderBy(x => x.Count() - x.Distinct().Count()).Last();
        }

        public static IEnumerable<string> GetWordsShorterThan5Letters_Refactored(
            IEnumerable<string> words)
        {
            return words.Where(x => x.Length < 5).Distinct();
        }


        public static IEnumerable<string> GetWordsShorterThan5Letters(
            IEnumerable<string> words)
        {
            var result = new List<string>();
            foreach (var word in words)
            {
                if (word.Length < 5 && !result.Contains(word))
                {
                    result.Add(word);
                }
            }
            return result;
        }
    }
}