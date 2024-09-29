using System.Text;

namespace ExercisesForPractice
{
    public static class GeneratingNewCollection
    {
        public static Dictionary<int, string> NewYearsEvesSince(
            int initialYear, int yearsCount)
        {
            return Enumerable.Range(0, yearsCount).Aggregate(new Dictionary<int, string>(), (res, next) => { res.Add(initialYear + next, new DateOnly(initialYear + next, 12, 31).DayOfWeek.ToString()); return res; });
        }
        public static string BuildTree(int levels)
        {
            return Enumerable.Range(1, levels).Aggregate(new StringBuilder(), (res, next) => res.Append(new string('*', next) + '\n')).ToString();
        }

        public static IEnumerable<string> DoubleLetters_Refactored(int countOfLetters)
        {
            countOfLetters = Math.Min(countOfLetters, 26);
            var alphabet = Enumerable.Range(0, countOfLetters).Aggregate(new StringBuilder(), (res, next) => res.Append((char)('A' + next))).ToString();
            throw new NotImplementedException();
            //TODO: SelectMany
        }

        public static IEnumerable<string> DoubleLetters(int countOfLetters)
        {
            const int CountOfLettersInEnglishAlphabet = 26;
            var finalCountOfLetters = Math.Min(
                countOfLetters,
                CountOfLettersInEnglishAlphabet);

            var allLetters = new List<char>();
            var letter = 'A';
            for (int i = 0; i < finalCountOfLetters; ++i)
            {
                allLetters.Add(letter);
                letter++;
            }

            var result = new List<string>();
            foreach (var firstLetter in allLetters)
            {
                foreach (var secondLetter in allLetters)
                {
                    result.Add($"{firstLetter}{secondLetter}");
                }
            }
            return result;
        }
    }
}
