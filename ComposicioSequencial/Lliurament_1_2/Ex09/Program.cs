namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double POLZADESCENTIMETRES = 2.54;
            const int CENTIMETRESMETRES = 100;

            Console.WriteLine("Tranformem de polzades a metres");
            double polzades = Convert.ToDouble(Console.ReadLine());
            double metres = Convert.ToDouble((polzades*POLZADESCENTIMETRES)/CENTIMETRESMETRES);
            Console.WriteLine($"{polzades} polzades en metres són {metres}");
        }
    }
}
