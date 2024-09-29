﻿namespace ExercisesForPractice
{
    public static class Average
    {
        public static float? AverageSnowFall(SnowFallData snowFallData)
        {
            if (snowFallData == null)
                return null;
            if (snowFallData.MonthlySnowFallDataItems == null)
                return null;
            if (snowFallData.MonthlySnowFallDataItems.Count != 12)
                return null;

            return snowFallData.MonthlySnowFallDataItems.Average(x => x.SnowfallInCentimeters);
        }
        public static double MaxAverageOfMarks(IEnumerable<Student> students)
        {
            return students.Select(x => x.Marks.Average()).Max();
        }

        public static float CalculateAverageHeight_Refactored(
            List<float?> heights, float defaultIfNull)
        {
            if (heights == null || heights.Count == 0)
                return 0;
            return heights.Average(x => x == null ? defaultIfNull : x.Value);
        }

        public static float CalculateAverageHeight(
            List<float?> heights, float defaultIfNull)
        {
            if (heights == null || heights.Count == 0)
            {
                return 0;
            }
            var sum = 0f;
            foreach (var height in heights)
            {
                if (height == null)
                {
                    sum += defaultIfNull;
                }
                else
                {
                    sum += height.Value;
                }
            }
            return sum / heights.Count;
        }

        public class Student
        {
            public IEnumerable<int> Marks { get; set; }
        }

        public class SnowFallData
        {
            public int Year { get; set; }
            public List<MonthlySnowFallData> MonthlySnowFallDataItems { get; set; }
        }

        public class MonthlySnowFallData
        {
            public int Month { get; set; }
            public float SnowfallInCentimeters { get; set; }
        }
    }
}