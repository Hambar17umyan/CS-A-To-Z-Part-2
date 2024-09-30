namespace ExercisesForPractice
{
    public static class Select
    {
        public static IEnumerable<int> GetNumbers(IEnumerable<object> objects)
        {
            return objects.Where(x => int.TryParse(x.ToString(), out int b)).Select(x => int.Parse(x.ToString()));
        }
        public static IEnumerable<Person> PeopleFromString(string input)
        {
            var people = input.Split(';');
            return people.Where(x =>
            {
                var format = x.Split(' ');

                return format.Count() == 3 && DateTime.TryParse(format[2], out var y);
            }).Select(x =>
            {
                var t = x.Split(' ');
                return new Person() { FirstName = t[0], LastName = t[1].Split(',')[0], DateOfBirth = DateTime.Parse(t[2]) };
            });
        }

        public static TimeSpan TotalDurationOfSongs_Refactored(string allSongsDuration)
        {
            if(!allSongsDuration.Any())
                return TimeSpan.Zero;
            return allSongsDuration.Split(',').Select(x => TimeSpan.ParseExact(x, @"m\:ss", null)).Aggregate(new TimeSpan(0, 0, 0), (res, next) => res += next);
        }

        public static TimeSpan TotalDurationOfSongs(
            string allSongsDuration)
        {
            if (string.IsNullOrEmpty(allSongsDuration))
            {
                return new TimeSpan();
            }

            var durationStrings = allSongsDuration.Split(',');
            var totalDuration = 0d;
            foreach (var durationString in durationStrings)
            {
                var timeSpan = TimeSpan.ParseExact(
                    durationString, @"m\:ss", null);
                totalDuration += timeSpan.TotalSeconds;
            }

            return TimeSpan.FromSeconds(totalDuration);
        }

        public class Person : IEquatable<Person>
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName} born on {DateOfBirth.ToString("d")}";
            }

            public bool Equals(Person other)
            {
                return FirstName == other.FirstName &&
                       LastName == other.LastName &&
                       DateOfBirth == other.DateOfBirth;
            }
        }
    }
}
