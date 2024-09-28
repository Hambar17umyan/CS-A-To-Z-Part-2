namespace ExercisesForPractice
{
    public static class Aggregate
    {
        public static TimeSpan TotalActivityDuration(
            IEnumerable<int> activityTimesInSeconds)
        {
            return activityTimesInSeconds.Aggregate(new TimeSpan(), (ts, sec) => ts += TimeSpan.FromSeconds(sec));
        }

        //Coding Exercise 2
        /*
         Using LINQ's Aggregate method implement the PrintAlphabet method which given 
        a count (assume it's from 1 to 26) will return a string with this count 
        of letters starting with 'a'.

        For example:
            *For count 5 it will return "a,b,c,d,e"
            *For count 3 it will return "a,b,c"
            *For count 1 it will return "a"
        
        For count less than 1 or more than 26 it will throw ArgumentException
         */
        public static string PrintAlphabet(int count)
        {
            if (count < 1 || count > 26)
                throw new ArgumentException();
            // TODO: NotImplemented
        }

        //Refactoring challenge
        //TODO implement this method
        public static IEnumerable<int> Fibonacci_Refactored(int n)
        {
            // TODO: NotImplemented
        }

        //do not modify this method
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