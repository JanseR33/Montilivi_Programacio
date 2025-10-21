namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantitatDeNumeros = 0;
            int suma = 0;

            Console.WriteLine("Introdueix números i es farà la mitjana total. Escriu 0 quan vulguis aturar el programa.");

            int numActual = int.Parse(Console.ReadLine());

            while (numActual != 0)
            {
                suma = suma + numActual;
                quantitatDeNumeros++;
                numActual = int.Parse(Console.ReadLine());
            }

            double resultat = suma / (double)quantitatDeNumeros;

            Console.WriteLine($"la mitja és {resultat}");
        }
    }
}
