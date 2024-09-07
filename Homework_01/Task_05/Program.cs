namespace Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pred = new MyPredicate(IsValid);

            var evenPred = new MyPredicate(bool (int x) =>
            {
                return x % 2 == 0;
            });

            var oddPred = new MyPredicate(bool (int x) =>
            {
                return x % 2 == 1;
            });

            var list = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29
            };
            var a = CheckConstraints(list, pred);
            var b = CheckConstraints(list, evenPred);
            var c = CheckConstraints(list, oddPred);

            foreach (var x in a)
                Console.Write(x.ToString() + ' ');

            Console.WriteLine();

            foreach (var x in b)
                Console.Write(x.ToString() + ' ');

            Console.WriteLine();

            foreach (var x in c)
                Console.Write(x.ToString() + ' ');

        }

        static List<int> CheckConstraints(List<int> list, MyPredicate predicate)
        {
            var res = new List<int>();
            foreach (var i in list)
            {
                if (predicate(i))
                    res.Add(i);
            }
            return res;
        }



        static bool IsValid(int x) => x >= 10 && x <= 18;
    }

    public delegate bool MyPredicate(int x);
}
