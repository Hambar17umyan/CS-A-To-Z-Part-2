using System.Linq;

namespace Task_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "Hello",
                "World",
                "!",
                "My",
                "Friend",
                "hOw",
                "are",
                "You",
                "?"
            };

            Predicate<string> predicate = (string str) => str.Length > 1 && str[0].ToString().ToLower() != "h";
            list = Where(list, predicate);
            foreach (string str in list) 
                Console.WriteLine(str);
        }

        static List<T> Where<T>(List<T> list, Predicate<T> predicate)
        {
            List<T> res = new List<T>();
            foreach (var item in list)
            {
                if (predicate(item))
                    res.Add(item);
            }

            return res;
        }
    }
}
