namespace ExercisesForPractice
{
    public static class Count
    {
        public static int CountAllLongWords(IEnumerable<string> words)
        {
            return words.Count(x => x.Length > 10);
        }
        public static bool AreThereFewerOddThanEvenNumbers(IEnumerable<int> numbers)
        {
            return numbers.Count(x => x % 2 == 0) > numbers.Count(x => x % 2 == 1);
        }
        public static bool IsAnySequenceTooLong_Refactored(IEnumerable<IEnumerable<int>> numberSequences, int maxLength)
        {
            return numberSequences.Any(x => x.Count() > maxLength);
        }

        public static bool IsAnySequenceTooLong(IEnumerable<IEnumerable<int>> numberSequences, int maxLength)
        {
            foreach (var numberSequence in numberSequences)
            {
                var count = 0;
                foreach (var number in numberSequence)
                {
                    ++count;
                }
                if (count > maxLength)
                {
                    return true;
                }
            }
            return false;
        }
    }
}