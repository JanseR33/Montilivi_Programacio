namespace M05
{
    internal class Program
    {
        double x;
        double y;
        double z;
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciona el valor d'X");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Selecciona el valor d'Y");
            double y = Convert.ToDouble(Console.ReadLine());
            double z = x + y;
            Console.WriteLine($"El resultat és: {z}");
        }
    }
}
