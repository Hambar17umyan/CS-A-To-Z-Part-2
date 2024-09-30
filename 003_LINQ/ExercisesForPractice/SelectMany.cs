using System.Net;

namespace ExercisesForPractice
{
    public static class SelectMany
    {
        public static IEnumerable<string> BuildCartesianProduct(
            HashSet<int> numbers)
        {
            return numbers.SelectMany(x => numbers.Select(y => $"{x},{y}"));
        }

        public static IEnumerable<string> BestMarksAndStudents(
            IEnumerable<Student> students)
        {
            return students.SelectMany(x => x.Marks.Select(y => ($"{x.Name}: {y}", y, x.Name))).OrderByDescending(x => x.Name).OrderBy(x => x.y).Select(x => x.Item1).TakeLast(5).Reverse();
        }

        public static Dictionary<string, double> SegmentsLengths_Refactored(
            IEnumerable<Point> starts, IEnumerable<Point> ends)
        {
            return starts.SelectMany(x => ends.Select(y => new KeyValuePair<string, double>($"Start: ({x}), End: ({y})", SegmentLength(x, y)))).ToDictionary(x => x.Key, y => y.Value);
        }

        public static Dictionary<string, double> SegmentsLengths(
            IEnumerable<Point> starts, IEnumerable<Point> ends)
        {
            var result = new Dictionary<string, double>();
            foreach (var startPoint in starts)
            {
                foreach (var endPoint in ends)
                {
                    var length = SegmentLength(startPoint, endPoint);
                    var key = $"Start: ({startPoint}), End: ({endPoint})";
                    result[key] = length;
                }
            }
            return result;
        }

        public static double SegmentLength(Point start, Point end)
        {
            return Math.Sqrt(Math.Pow(start.X - end.X, 2) + Math.Pow(start.Y - end.Y, 2));
        }

        public class Student
        {
            public string Name { get; set; }
            public IEnumerable<int> Marks { get; set; }

            public override string ToString()
            {
                return $"{Name} with marks ({string.Join(",", Marks)})";
            }
        }

        public struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public override string ToString()
            {
                return $"X: {X}, Y: {Y}";
            }
        }
    }
}
