namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDel del1 = new MyDel(PrintHello);
            MyDel del2 = new MyDel(PrintWorld);
            var res = del1 + del2;

            res.Invoke();
        }

        static void PrintHello()
        {
            Console.Write("Hello");
        }
        static void PrintWorld()
        {
            Console.Write(" World!");
        }
    }

    public delegate void MyDel();
}
