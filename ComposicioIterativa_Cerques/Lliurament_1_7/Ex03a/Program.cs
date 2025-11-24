namespace Ex03a
{
    internal class Program
    {
        /// <summary>
        /// Donada una seqüència d’enters, indicar si hi ha algun número parell.
        /// Versió 1: La seqüència prové d’un fitxer de text (un enter per línia).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string NOM_FITXER_PARELL = "NUMEROS.txt";
            const string NOM_FITXER_IMPARELL = "NUMEROS2.txt";

            StreamReader lectorFitxer;
            lectorFitxer = new StreamReader(NOM_FITXER_PARELL);
            string? linia = lectorFitxer.ReadLine();
            int numActual = int.Parse(linia);

            while (linia != null && numActual % 2 != 0)
            {
                numActual = int.Parse(linia);
                linia = lectorFitxer.ReadLine();
            }

            if (linia == null)
            {
                Console.WriteLine("No hi ha cap nombre parell en l'arxiu.");
            }
            else
            {
                Console.WriteLine("Hi ha nombres parells.");
            }
        }
    }
}
