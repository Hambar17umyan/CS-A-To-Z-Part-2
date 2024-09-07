namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> del = (double a) => Math.Round(a);
            Console.WriteLine(del.Invoke(17.6));
        }
    }
}
