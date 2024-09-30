namespace ExercisesForPractice
{
    public static class PrependAppend
    {
        public static IEnumerable<string> AddStartAndEndMarkers(IEnumerable<string> words)
        {
            return words.First() == "START" ?
                words.Last() == "END" ?
                words :
                words.Append("END") :
                words.Last() == "END" ?
                words.Prepend("START") :
                words.Prepend("START").Append("END");
        }

        public static IEnumerable<int> RemoveDuplicatesFromStartAndEnd(
            IEnumerable<int> numbers)
        {
            if(numbers == null || !numbers.Any())
                return Enumerable.Empty<int>();
            if(numbers.Count() == 1)
                return numbers;
            var res = numbers.Where(x => x != numbers.First() & x != numbers.Last());
            if (res.Any()) 
                return res.Prepend(numbers.First()).Append(numbers.Last());
            else 
                return numbers.Take(1);
        }

        public static IEnumerable<string> TrimSentenceAndChangeEndMarker_Refactored(
            IEnumerable<string> words)
        {
            return words.TakeWhile(x => x != "The end").Append("END");
        }

        public static IEnumerable<string> TrimSentenceAndChangeEndMarker(IEnumerable<string> words)
        {
            var result = new List<string>();
            foreach (var word in words)
            {
                if (word != "The end")
                {
                    result.Add(word);
                }
                else
                {
                    break;
                }
            }
            result.Add("END");
            return result;
        }
    }
}
