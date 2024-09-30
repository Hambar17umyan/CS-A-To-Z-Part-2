namespace ExercisesForPractice
{
    public static class Skip
    {
        public static double CalculateAverageMark(Student student)
        {
            return student.Marks.Count() < 3 ? 0 : student.Marks.OrderBy(x => x).Skip(1).SkipLast(1).Average();
        }
        public static IEnumerable<string> GetWordsBetweenStartAndEnd(List<string> words)
        {
            if (words.Count(x => x == "START") != 1)
                return Enumerable.Empty<string>();
            if (words.Count(x => x == "END") != 1)
                return Enumerable.Empty<string>();

            return words.SkipWhile(x => x != "START").Reverse().SkipWhile(x => x != "END").Reverse().Skip(1).SkipLast(1);
        }

        public static IEnumerable<int> GetAllAfterFirstDividableBy100_Refactored(
            IEnumerable<int> numbers)
        {
            return numbers.SkipWhile(x => x % 100 != 0);
        }

        public static IEnumerable<int> GetAllAfterFirstDividableBy100(IEnumerable<int> numbers)
        {
            var result = new List<int>();
            bool startAdding = false;
            foreach (var number in numbers)
            {
                if (!startAdding && number % 100 == 0)
                {
                    startAdding = true;
                }
                if (startAdding)
                {
                    result.Add(number);
                }
            }
            return result;
        }

        public class Student
        {
            public IEnumerable<int> Marks { get; set; }
        }
    }
}
