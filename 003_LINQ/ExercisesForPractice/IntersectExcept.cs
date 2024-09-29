using static ExercisesForPractice.IntersectExcept;

namespace ExercisesForPractice
{
    public static class IntersectExcept
    {
        public static int CountCommonWords(
            IEnumerable<string> words1,
            IEnumerable<string> words2)
        {
            return words1.Intersect(words2.Select(x => x.ToLower())).Count();
        }

        public static IEnumerable<int> GetExclusiveNumbers(
            IEnumerable<int> numbers1,
            IEnumerable<int> numbers2)
        {
            var inter = numbers1.Intersect(numbers2);
            return numbers1.Except(inter).Concat(numbers2.Except(inter)).Order();
        }
        public static IEnumerable<string>
            GetRoutesInfo_Refactored(
                Route route1, Route route2)
        {
            var inter = route1.RoutePoints.Intersect(route2.RoutePoints);
            var exclusive = route1.RoutePoints.Except(inter).Concat(route2.RoutePoints.Except(inter));
            return inter.Select(x => $"Shared point " + $"{x.Name}" + $" at {x.Point}").Concat(exclusive.Select(x=> $"Unshared point " + $"{x.Name}" + $" at {x.Point}"));
        }

        public static IEnumerable<string> GetRoutesInfo(
           Route route1, Route route2)
        {
            var result = new List<string>();
            var sharedPoints = new List<RoutePoint>();
            foreach (var routePoint1 in route1.RoutePoints)
            {
                foreach (var routePoint2 in route2.RoutePoints)
                {
                    if (routePoint1.Equals(routePoint2))
                    {
                        if (!sharedPoints.Contains(routePoint1))
                        {
                            sharedPoints.Add(routePoint1);
                            result.Add($"Shared point " +
                            $"{routePoint1.Name}" +
                            $" at {routePoint1.Point}");
                        }
                    }
                }
            }
            foreach (var routePoint in route1.RoutePoints)
            {
                if (!sharedPoints.Contains(routePoint))
                {
                    result.Add(
                        $"Unshared point " +
                        $"{routePoint.Name}" +
                        $" at {routePoint.Point}");
                }
            }
            foreach (var routePoint in route2.RoutePoints)
            {
                if (!sharedPoints.Contains(routePoint))
                {
                    result.Add(
                        $"Unshared point " +
                        $"{routePoint.Name}" +
                        $" at {routePoint.Point}");
                }
            }

            return result;
        }

        public class Route
        {
            public IEnumerable<RoutePoint> RoutePoints { get; }
            public Route(IEnumerable<RoutePoint> routePoints)
            {
                RoutePoints = routePoints;
            }

            public override string ToString()
            {
                return $"RoutePoints: ({string.Join("; ", RoutePoints)})";
            }
        }
        public struct RoutePoint
        {
            public string Name { get; }
            public Point Point { get; }
            public RoutePoint(string name, Point point)
            {
                Name = name;
                Point = point;
            }
            public override string ToString()
            {
                return $"{Name} ({Point})";
            }
        }
        public struct Point
        {
            public double X { get; }
            public double Y { get; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return $"X: {X}, Y: {Y}";
            }
        }
    }
}
