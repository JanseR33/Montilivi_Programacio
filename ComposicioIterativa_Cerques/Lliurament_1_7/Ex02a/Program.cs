namespace Ex02a
{
    internal class Program
    {
        /// <summary>
        /// Donada una seqüència d’enters, informar si el primer valor es repeteix.
        /// Podem considerar un número per línia. 
        /// Versió 1: La seqüència prové d’un fitxer de text que conté com a mínim un número.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string NOM_FITXER = "NUMEROS.TXT";
            StreamReader fitxerNumeros;
            fitxerNumeros = new StreamReader(NOM_FITXER);
            bool repetit = false;
            string? lineaActual;
            // Aquest és el primer número de la llista, el valor que s'ha de buscar
            int primerNum = Convert.ToInt32(fitxerNumeros.ReadLine());
            // Aquesta línea s'actualitza cada cop que es repeteix el bucle. Fins que no sigui null, no pararà (good)
            while ((lineaActual = fitxerNumeros.ReadLine()) != null && !repetit)
            {
                int nombreActual = Convert.ToInt32(lineaActual);
                if (primerNum == nombreActual)
                {
                    repetit = true;
                }    
            }

            if (repetit == true)
            {
                Console.WriteLine("El primer nombre es repeteix");
            }
            else Console.WriteLine("Després d'analitzar la llista sencera, el primer número no es repeteix.");
        }
    }
}
