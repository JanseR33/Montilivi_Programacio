using System.Runtime.CompilerServices;

namespace Ex07
{
    internal class Program
    {
        /// <summary>
        /// Fer un programa que vagi demanant números fins trobar el zero i ens digui el valor més gran i el valor més petit.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int numPetit;
            int numGran;

            Console.WriteLine("Introdueix un número");
            int n = int.Parse(Console.ReadLine());

            numGran = n;
            numPetit = n;

            while (n != 0)
            {
                if (n > numGran)
                {
                    numGran = n;
                }
                else if (n < numPetit)
                {
                    numPetit = n;
                }

                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"De tots els nombres entrats, el més petit és {numPetit} i el més gran és {numGran}.");
        }
    }
}
