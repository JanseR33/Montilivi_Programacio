namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entra un número: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}
