namespace Task_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            List<Human> list1 = new List<Human>();
            for (int i = 0; i < 10; i++)
            {
                var a = new Human()
                {
                    ID = i,
                    Age = rand.Next(1, 100),
                    Name = $"Name{i}"
                };
                list1.Add(a);
                Console.WriteLine(a);
            }
            Comparison<Human> comparison = (Human a, Human b) => a.Age - b.Age;
            list1.Sort(comparison);
            Console.WriteLine("Sorted:\n");
            foreach (var b in list1)
                Console.WriteLine(b);

            Console.WriteLine("++++++++++++++++++++++++++++++++++");


            List<Human> list2 = new List<Human>();
            for (int i = 0; i < 10; i++)
            {
                var a = new Human()
                {
                    ID = i,
                    Age = rand.Next(1, 100),
                    Name = $"Name{i}"
                };
                list2.Add(a);
                Console.WriteLine(a);
            }
            Console.WriteLine("Sorted: ");
            Human.Sort(list2);
            foreach(var b in list2)
                Console.WriteLine(b);
        }
    }

    internal class Human
    {
        public int ID;
        public int Age;
        public string Name;

        public static void Sort(List<Human> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (FirstIsGreater(list[j - 1], list[j]))
                    {
                        var repl = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = repl;
                    }
                    else break;
                }
            }
        }
        private delegate bool ComparisonDelegate(Human human1, Human human2);
        private static ComparisonDelegate FirstIsGreater = (Human a, Human b) => a.Age >= b.Age;

        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nAge: {Age}\n--------------------------\n";
        }
    }
}
