using static System.Net.Mime.MediaTypeNames;

namespace Ex06b
{
    internal class Program
    {
        /// <summary>
        /// Un nombre és primer si és divisible només per ell mateix i per 1. El 0 i l’ 1 es consideren no primers per definició.
        /// Escriu un programa per saber si un nombre positiu introduït pel teclat és primer o no.
        /// Escriu la funció public static bool EsPrimer(int n) que retorna true si n és un número primer i seguidament, reescriu el programa 6a usant la funció
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int numEntrat = int.Parse(Console.ReadLine());
            bool esPrimer = EsPrimer(numEntrat);

            if (esPrimer)
            {
                Console.WriteLine($"{numEntrat} és un nombre primer.");
            }
            else
            {
                Console.WriteLine($"{numEntrat} no és un nombre primer.");
            }
        }

        public static bool EsPrimer(int numEntrat)
        {
            int divisioActual = 2;
            int cont = 0;
            bool resultat;
            while (divisioActual <= numEntrat / 2 && cont != 1)
            {
                if (numEntrat % divisioActual == 0) cont++;
                divisioActual++;
            }
            if (cont == 1)
            {
                 resultat = true;
            }
            else resultat =false;

            return resultat;
        }
    }
}
