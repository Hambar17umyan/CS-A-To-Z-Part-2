using System.Text;

namespace ExercisesForPractice
{
    public static class ConcatUnion
    {
        public static IEnumerable<News> SelectRecentAndImportant(
            IEnumerable<News> newsCollection)
        {
            return newsCollection.OrderBy(x => x.PublishingDate).TakeLast(3).Union(newsCollection.Where(x => x.Priority == Priority.High));
        }

        public static string CleanWord(string word)
        {
            string s = (word.Where(x => (x >= 'A' && x <= 'Z') || (x >= 'a' && x <= 'z')).Concat(word.Where(x => !(x >= 'A' && x <= 'Z') && !(x >= 'a' && x <= 'z')).Distinct())).Aggregate(new StringBuilder(), (res, next) => res.Append(next)).ToString();
            return s;
        }

        public static IEnumerable<int> GetPerfectSquares_Refactored(
            IEnumerable<int> numbers1, IEnumerable<int> numbers2)
        {
            return numbers1.Concat(numbers2).Distinct().Where(x => Math.Pow(Math.Sqrt(x), 2) == x);
        }

        public static IEnumerable<int> GetPerfectSquares(IEnumerable<int> numbers1, IEnumerable<int> numbers2)
        {
            var result = new List<int>();
            foreach (var number in numbers1)
            {
                if (Math.Sqrt(number) % 1 == 0 && !result.Contains(number))
                {
                    result.Add(number);
                }
            }
            foreach (var number in numbers2)
            {
                if (Math.Sqrt(number) % 1 == 0 && !result.Contains(number))
                {
                    result.Add(number);
                }
            }
            result.Sort();
            return result;
        }

        public struct News
        {
            public DateTime PublishingDate { get; set; }
            public Priority Priority { get; set; }

            public override string ToString()
            {
                return $"Date: {PublishingDate.ToString("d")}, Priority: {Priority}";
            }
        }

        public enum Priority
        {
            Low,
            Medium,
            High
        }
    }
}