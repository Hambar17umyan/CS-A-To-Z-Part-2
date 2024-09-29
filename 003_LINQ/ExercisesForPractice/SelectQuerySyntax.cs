namespace ExercisesForPractice
{
    public static class SelectQuerySyntax
    {
        public static IEnumerable<string>
            GetAbsoluteValuesInfo(IEnumerable<int> numbers)
        {
            return from number in numbers select $"|{number}|={Math.Abs(number)}";
        }

        public static IEnumerable<string> GetShortAddresses(IEnumerable<House> houses)
        {
            return from house in houses select house.Address.Split(',').Length == 3 ? house.Address.Split(',')[1].Trim() : house.Address;
        }

        public static string? GetBestStudentInfo_Refactored(
            IEnumerable<Student> students)
        {
            return students.Any() ?
                (from student in students orderby student.Marks.Max() let best = students.Last()
                select $"Best mark was earned by {best.Name} and it is {best.Marks.Max()}").FirstOrDefault()
                : null;
        }

        public static string GetBestStudentInfo(IEnumerable<Student> students)
        {
            var studentsAsList = students.ToList();
            if (studentsAsList.Count == 0)
            {
                return null;
            }

            var studentWithMaxMark = studentsAsList[0];
            var maxMark = 0;
            foreach (var student in studentsAsList)
            {
                var studentsMaxMark = student.Marks.Any() ?
                    student.Marks.Max() :
                    0;
                if (studentsMaxMark > maxMark)
                {
                    maxMark = studentsMaxMark;
                    studentWithMaxMark = student;
                }
            }

            return $"Best mark was earned by " +
                   $"{studentWithMaxMark.Name}" +
                   $" and it is {maxMark}";
        }

        public class House
        {
            public string Address { get; }

            public House(string address)
            {
                Address = address;
            }

            public override string ToString()
            {
                return Address;
            }
        }

        public class Student
        {
            public string Name { get; set; }
            public IEnumerable<int> Marks { get; set; }

            public override string ToString()
            {
                return $"{Name} with marks ({string.Join(", ", Marks)})";
            }
        }
    }
}
