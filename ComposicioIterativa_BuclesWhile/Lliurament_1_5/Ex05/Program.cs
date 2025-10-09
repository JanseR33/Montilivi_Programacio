namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nTotal = 0;
            int suma = 0;

            Console.WriteLine("Introdueix números i es farà la mitjana total. Escriu 0 quan vulguis aturar el programa.");

            int n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                suma = suma + n;
                nTotal++;
                n = int.Parse(Console.ReadLine());
            }
            int resultat = suma / nTotal;

            Console.WriteLine($"la mitja és {resultat}");
        }
    }
}
