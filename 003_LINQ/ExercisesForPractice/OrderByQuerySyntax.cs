using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesForPractice
{
    public static class OrderByQuerySyntax
    {
        public static IEnumerable<TimeSpan>
            OrderFromLongestToShortest(
                IEnumerable<TimeSpan> timeSpans)
        {
            return from timespan in timeSpans orderby timespan.Seconds select timespan;
        }
        public static IEnumerable<Point> OrderPoints(
             IEnumerable<Point> points)
        {
            return from point in points orderby point.X, point.Y select point; 
        }
        public static IEnumerable<DateTime>
            OrderDatesByDayOfWeek_Refactored(
                IEnumerable<DateTime> dates)
        {
            return from date in dates orderby date.DayOfWeek select date;
        }

        public static IEnumerable<DateTime>
            OrderDatesByDayOfWeek(
                IEnumerable<DateTime> dates)
        {
            var result = dates.ToList();
            result.Sort((left, right) =>
            {
                return left.DayOfWeek.CompareTo(right.DayOfWeek);
            });
            return result;
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
