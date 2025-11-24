using System.Diagnostics.Tracing;

namespace Ex08
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa que llegeixi una seqüència d’enters d’un fitxer i ens informi
        /// si es compleix sempre la condició que l’element llegit és igual a la suma de tots els anteriors que han aparegut.
        /// El resultat del programa és "SÍ" si compleix la condició i "NO" si no la compleix.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FITX_COMP = "COMPLEIX.txt";
            const string FITX_NO = "NOCOMPLEIX.txt";

            StreamReader lectorFitxer = new StreamReader(FITX_COMP);

            string? linea = lectorFitxer.ReadLine();
            int numTotal = 0;
            int numActual = 0;

            while (linea != null && numTotal == numActual)
            {
                numActual = int.Parse(linea);
                numTotal = +numActual;
                linea = lectorFitxer.ReadLine();
            }
            if (linea == null)
            {
                Console.WriteLine("SÍ");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
