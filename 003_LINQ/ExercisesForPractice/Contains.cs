namespace ExercisesForPractice
{
    public static class Contains
    {
        public static bool IsAppointmentDateAvailable(
            DateTime date, IEnumerable<DateTime> existingAppointmentDates)
        {
            return !existingAppointmentDates.Contains(date);
        }

        public static int CountFriendsOf(Friend friend, IEnumerable<Person> people)
        {
            return people.Count(x => x.Friends.Contains(friend));
        }

        public static bool ContainsBannedWords_Refactored(
            IEnumerable<string> words, IEnumerable<string> bannedWords)
        {
            return words.Any(x => bannedWords.Contains(x));
        }

        public static bool ContainsBannedWords(
            IEnumerable<string> words, IEnumerable<string> bannedWords)
        {
            foreach (var word in words)
            {
                foreach (var bannedWord in bannedWords)
                {
                    if (word == bannedWord)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public class Person
        {
            public string Name { get; }
            public IEnumerable<Friend> Friends { get; }

            public Person(string name, IEnumerable<Friend> friends)
            {
                Name = name;
                Friends = friends;
            }
        }

        public class Friend
        {
            public string Name { get; }
        }
    }
}