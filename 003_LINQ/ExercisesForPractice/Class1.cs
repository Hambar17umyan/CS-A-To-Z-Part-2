using System.Text;

namespace ExercisesForPractice
{
    public static class Aggregate
    {
        public static TimeSpan TotalActivityDuration(
            IEnumerable<int> activityTimesInSeconds)
        {
            return activityTimesInSeconds.Aggregate(new TimeSpan(), (ts, sec) => ts += TimeSpan.FromSeconds(sec));
        }

        public static string PrintAlphabet(int count)
        {
            if (count < 1 || count > 26)
                throw new ArgumentException();
            return Enumerable.Range(1, count - 1).Aggregate("a", (res, next) => res += $",{(char)('a' + next)}");
        }

        public static IEnumerable<int> Fibonacci_Refactored(int n)
        {
            return n < 1 ?
                throw new ArgumentException(
                    $"Can't generate Fibonacci sequence " +
                    $"for {n} elements. N must be a " +
                    $"positive number")
                : n == 1 ?
                new[] { 0 }
                : Enumerable.Range(2, n - 2).Aggregate(new List<int> { 0, 1 }, (coll, next) => { coll.Add(coll.Last() + coll.SkipLast(1).Last()); return coll; })
                ;
        }

        public static IEnumerable<int> Fibonacci(int n)
        {
            if (n < 1)
            {
                throw new ArgumentException(
                    $"Can't generate Fibonacci sequence " +
                    $"for {n} elements. N must be a " +
                    $"positive number");
            }

            if (n == 1)
            {
                return new[] { 0 };
            }
            var result = new List<int> { 0, 1 };
            for (int i = 1; i < n - 1; ++i)
            {
                result.Add(result[i - 1] + result[i]);
            }
            return result;
        }
    }
}