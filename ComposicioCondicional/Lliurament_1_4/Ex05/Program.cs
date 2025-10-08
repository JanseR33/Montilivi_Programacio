using System.Security.Cryptography.X509Certificates;
using System.Timers;

namespace Ex05
{
    internal class Program
    {
        /// <summary>
        /// Aquest programa mira si un programa és parell o imparell i si és múltiple de 7.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Entra un nombre i et dirè si és parell o senar i si és múltiple de 7 o no");
            int numeroEntrat = int.Parse(Console.ReadLine());

            if (numeroEntrat == 0)
            {
                Console.WriteLine("Posa un número que sigui parell o senar");
            }
            bool parellImparell = EsParell(numeroEntrat);
            if (parellImparell)
            {
                Console.WriteLine("El número és imparell");
            }
            else
            {
                Console.WriteLine("El número és parell");
            }
            bool multiple7 = Multiple7(numeroEntrat);
            if (multiple7)
            {
                Console.WriteLine("El número és multiple de 7");
            }
        }
        /// <summary>
        /// Aquesta funció mira si el nombre entrat és parell o imparell
        /// </summary>
        /// <param name="n">Nombre entrat per usuari</param>
        /// <returns></returns>
            public static bool EsParell(int n)
        {
         bool resultat = false;

            if (n % 2 != 0)
            {
                resultat = true;
            }
            else
            {
                resultat = false;
            }
            return resultat;
        }

        /// <summary>
        /// Aquesta funció mira si el nombre entrat és múltiple de 7
        /// </summary>
        /// <param name="n">nombre entrat per l'usuari</param>
        /// <returns></returns>
        public static bool Multiple7(int n)
        {
            bool multipleDe7 = false;

            if (n % 7 == 0)
            {
                multipleDe7 = true;
            }
            else { multipleDe7 = false; }

            return multipleDe7;
        }
        }
    }
