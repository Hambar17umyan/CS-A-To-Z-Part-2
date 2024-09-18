namespace Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, List<int>> asc = delegate (List<int> list)
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        if (list[j - 1] >= list[j])
                        {
                            var e = list[j];
                            list[j] = list[j - 1];
                            list[j - 1] = e;
                        }
                        else break;
                    }
                }
                return list;
            };

            Func<List<int>, List<int>> desc = delegate (List<int> list)
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        if (list[j - 1] <= list[j])
                        {
                            var e = list[j];
                            list[j] = list[j - 1];
                            list[j - 1] = e;
                        }
                        else break;
                    }
                }
                return list;
            };

            var list = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29
            };


            desc(list);
            foreach (var item in list)
                Console.Write(item.ToString() + ' ');
            Console.WriteLine();

            asc(list);
            foreach (var item in list)
                Console.Write(item.ToString() + ' ');
            Console.WriteLine();

        }
    }
}
