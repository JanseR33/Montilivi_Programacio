namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assigna un valor a A");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a == 0) {
                Console.WriteLine("A no pot ser 0");
                return;
            }
            Console.WriteLine("Assigna un valor a B");
            double b = Convert.ToDouble(Console.ReadLine());
            double x = -b / a;
            Console.WriteLine($"L'equació és: {a}x + {b} = 0");
            Console.WriteLine($"La solució és: x = {x:0.00}");
        }
    }
}
