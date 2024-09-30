namespace ExercisesForPractice
{
    public static class OfType
    {
        public static int? GetTheFirstInteger(IEnumerable<object> objects)
        {
            return objects.OfType<int?>().FirstOrDefault(defaultValue: null);
        }

        public static bool AreAllStringsUpperCase(IEnumerable<object> objects)
        {
            return objects.OfType<string>().All(x => x[0] >= 'A' && x[0] <= 'Z');
        }

        public static DateTime? GetTheLatestDate_Refactored(IEnumerable<object> objects)
        {
            var res = objects.OfType<DateTime>();
            if (res.Count() == 0)
                return null;
            return res.Max();
        }

        public static DateTime? GetTheLatestDate(IEnumerable<object> objects)
        {
            DateTime? lastDate = null;
            foreach (var obj in objects)
            {
                var dateTime = obj as DateTime?;
                if (dateTime != null)
                {
                    if (lastDate == null || lastDate < dateTime)
                    {
                        lastDate = dateTime;
                    }
                }
            }
            return lastDate;
        }
    }
}
