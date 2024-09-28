namespace ExercisesForPractice
{
    public static class Sum
    {
        public static int TotalLength(IEnumerable<string> words)
        {
            return words.Sum(x => x.Length);
        }

        public static double AverageSum(
            IEnumerable<IEnumerable<int>> collectionsOfNumbers)
        {
            return collectionsOfNumbers.Average(x => x.Sum());
        }

        public static bool HasAnyStudentSumOfMarksLargerThan100_Refactored(
            IEnumerable<Student> students)
        {
            return students.Any(x => x.Marks.Sum() > 100);
        }

        public static bool HasAnyStudentSumOfMarksLargerThan100(
            IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                var sumOfMarks = 0;
                foreach (var mark in student.Marks)
                {
                    sumOfMarks += mark;
                }
                if (sumOfMarks > 100)
                {
                    return true;
                }
            }
            return false;
        }

        public class Student
        {
            public IEnumerable<int> Marks { get; set; }
        }
    }
}
