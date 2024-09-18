namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDelegate del = delegate (string text)
            {
                Console.WriteLine(text);
            };
            string str = "SampleString";

            del.Invoke(str);
        }
    }

    public delegate void PrintDelegate(string text);
}
