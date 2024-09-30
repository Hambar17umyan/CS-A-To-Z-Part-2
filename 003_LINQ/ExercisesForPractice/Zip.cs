using System.Text;

namespace ExercisesForPractice
{
    public static class Zip
    {
        public static IEnumerable<DateTime> BuildDates(
            IEnumerable<int> years,
            IEnumerable<int> months,
            IEnumerable<int> days)
        {

            return years.Zip(months, days).Select(x => new DateTime(x.First, x.Second, x.Third)).Order();
        }

        public static IEnumerable<string>
            GetDaysDifferencesBetweenDates(
                IEnumerable<DateTime> dates)
        {
            return dates.Zip(dates.Skip(1)).Select(x => $"It's been {(x.Second - x.First).Days} days between {x.First.ToString("yyyy-MM-dd")} and {x.Second.ToString("yyyy-MM-dd")}");
        }

        public static IEnumerable<string> MakeList_Refactored(IEnumerable<string> words)
        {
            return Enumerable.Range(0, 26).Aggregate(new StringBuilder(), (res, next) => res.Append((char)('A' + next))).ToString().Zip(words).Select(z => $"{z.First}) {z.Second}");
        }

        public static IEnumerable<string> MakeList(IEnumerable<string> words)
        {
            var result = new List<string>();
            char letter = 'A';
            foreach (var word in words)
            {
                result.Add($"{letter}) {word}");
                letter++;
            }
            return result;
        }
    }
}
