namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticDelegate del1 = new ArithmeticDelegate(Add);
            ArithmeticDelegate del2 = new ArithmeticDelegate(Multiply);

            Console.WriteLine("Enter the first Number!");
            if(!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            Console.WriteLine("Enter the second Number!");
            if (!int.TryParse(Console.ReadLine(),out int b))
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            Console.WriteLine($"{a} + {b} = {del1.Invoke(a, b)}");
            Console.WriteLine($"{a} * {b} = {del2.Invoke(a, b)}");
        }

        static int Add(int a, int b) => a + b;
        static int Multiply(int a, int b) => a * b;
    }

    public delegate int ArithmeticDelegate(int a, int b);
}
