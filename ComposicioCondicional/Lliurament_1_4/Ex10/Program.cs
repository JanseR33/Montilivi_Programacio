namespace Ex10
{
    internal class Program
    {
        /// <summary>
        /// Porgrama per desxifrar en quin segle es troba.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueix un valor en el rang de 1700 i 2100");
            int numeroIntroduit = int.Parse(Console.ReadLine());
            string resultatPasarNumeroRoma = PasarANumeroRoma(numeroIntroduit);

            Console.WriteLine(resultatPasarNumeroRoma);
        }
        /// <summary>
        /// Funció per transformar el nombre itroduït a nombre romà
        /// </summary>
        /// <param name="numeroIntroduit">Núm introduït per l'usuari</param>
        /// <returns></returns>
        static string PasarANumeroRoma(int numeroIntroduit)
        {
            string resultat;

            if (numeroIntroduit > 1700 && numeroIntroduit < 1801)
            {
                resultat = ($"D'acord al nombre {numeroIntroduit}, el segle en el que està situat és el XVIII");
            }
            else if (numeroIntroduit < 1901)
            {
                resultat = ($"D'acord al nombre {numeroIntroduit} el segle en el que està situat és el XIX");
            }
            else if (numeroIntroduit < 2001)
            {
                resultat = ($"D'acord al nombre {numeroIntroduit} el segle en el que està situat és el XX");
            }
            else if (numeroIntroduit < 2101)
            {
                resultat = ($"D'acord al nombre {numeroIntroduit} el segle en el que està situat és el XXI");
            }
            else resultat = ($"Siusplau, introdueix un valor dins del rang establert");

            return resultat;
        }
    }
}
    }
}
