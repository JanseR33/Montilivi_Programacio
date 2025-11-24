namespace Ex06d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string NOM_FITXER = "ALGUNSPRIMERS.txt";
            if (!File.Exists(NOM_FITXER))
            {
                Console.WriteLine($"El fitxer {NOM_FITXER} no existeix.");
                return;
            }

            StreamReader lectorFitxer = new StreamReader(NOM_FITXER);
            string? linia;
            bool trobat = false;

            while (!trobat && (linia = lectorFitxer.ReadLine()) != null)
            {
                int liniaNum = int.Parse(linia);

                if (EsPrimer(liniaNum))
                {
                    trobat = true;
                }
            }

            lectorFitxer.Close();

            if (trobat)
            {
                Console.WriteLine("En l'arxiu hi ha algun nombre primer.");
            }
            else
            {
                Console.WriteLine("En l'arxiu no hi ha cap nombre primer.");
            }
        }

        /// <summary>
        /// Funció que determina si un nombre és primer.
        /// </summary>
        /// <param name="num">El nombre a avaluar</param>
        /// <returns>True si és primer, False si no ho és.</returns>
        static bool EsPrimer(int num)
        {
            if (num <= 1) return false;

            int divisioActual = 2;
            bool esDivisible = false;

            while (divisioActual <= num / 2 && !esDivisible)
            {
                if (num % divisioActual == 0)
                {
                    esDivisible = true;
                }
                divisioActual++;
            }

            return !esDivisible;
        }
    }
}