using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesForPractice
{
    public static class OrderBy
    {
        public static IEnumerable<string> OrderFromLongestToShortest(
            IEnumerable<string> words)
        {
            return words.OrderBy(x => -x.Length);
        }

        public static IEnumerable<int> FirstEvenThenOddDescending(
            IEnumerable<int> numbers)
        {
            return numbers.Where(x => x % 2 == 0).OrderBy(x => -x).Concat(numbers.Where(x => x % 2 == 1).OrderBy(x => -x));
        }

        public static IEnumerable<DateTime> OrderByMonth_Refactored(List<DateTime> dates)
        {
            return dates.OrderBy(x => x.Month);
        }

        public static IEnumerable<DateTime> OrderByMonth(List<DateTime> dates)
        {
            dates.Sort((left, right) =>
            {
                return left.Month.CompareTo(right.Month);
            });
            return dates;
        }
    }
}
