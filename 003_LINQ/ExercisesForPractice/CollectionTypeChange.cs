namespace ExercisesForPractice
{
    public static class CollectionTypeChange
    {
        public static Dictionary<string, int?> ParseToNumbersAndStoreInDictionary(
             IEnumerable<string> words)
        {
            return words.Distinct().ToDictionary(x => x, y => int.TryParse(y, out int res) ? (int?)res : null);
        }

        public static ILookup<bool, int> CreateLookupByDivisibilityBy2(
            IEnumerable<int> input)
        {
            return input.ToLookup(x => x % 2 == 0);
        }

        public static Dictionary<string, double>
             GetStudentsAverageMarks_Refactored(
                 IEnumerable<Student> students)
        {
            return students.Select(x => (x.Marks.Average(), $"{x.FirstName} " +
                    $"{x.LastName} born on" +
                    $" {x.DateOfBirth.ToString("d")}")).ToDictionary(x => x.Item2, y => y.Item1);
        }

        public static Dictionary<string, double>
            GetStudentsAverageMarks(
                IEnumerable<Student> students)
        {
            var result = new Dictionary<string, double>();
            foreach (var student in students)
            {
                var studentData = $"{student.FirstName} " +
                    $"{student.LastName} born on" +
                    $" {student.DateOfBirth.ToString("d")}";

                var marksSum = 0;
                foreach (var mark in student.Marks)
                {
                    marksSum += mark;
                }
                var marksCount = student.Marks.Count();
                var averageMark = marksCount == 0 ?
                    0 :
                    marksSum / (float)marksCount;
                result[studentData] = averageMark;
            }
            return result;
        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public IEnumerable<int> Marks { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName}, {DateOfBirth.ToString("d")}, Marks = {string.Join(", ", Marks)}";
            }
        }
    }
}