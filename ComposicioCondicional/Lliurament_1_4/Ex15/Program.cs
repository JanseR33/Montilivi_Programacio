namespace Ex15
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa per tal de sumar un segon a una hora, minut i segon entrats per teclat.
        /// Mostra l’hora inicial i l’hora incrementada en un segon en format hh:mm:ss.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("introdueix les hores (0-23)");
            int horesIntroduides = int.Parse(Console.ReadLine());

            Console.WriteLine("introdueix els minuts (0-59)");
            int minutsIntroduits = int.Parse(Console.ReadLine());

            Console.WriteLine("introdueix els segons (0-59)");
            int segonsIntroduits = int.Parse(Console.ReadLine());

            string resultat = AfegirSegonsAMinutsIHores(horesIntroduides, minutsIntroduits, segonsIntroduits);

            Console.WriteLine(resultat);
        }
        /// <summary>
        /// En aquesta funció es fa el càlcul i el format hh:mm:ss.
        /// </summary>
        /// <param name="horesIntroduides">Aquest és el valor de les hores introduïdes per l'usuari</param>
        /// <param name="minutsIntroduits">Aquest és el valor dels minuts introduïts per l'usuari</param>
        /// <param name="segonsIntroduits">Aquest és el valor dels segons introduïts per l'usuari</param>
        /// <returns></returns>
        static string AfegirSegonsAMinutsIHores(int horesIntroduides, int minutsIntroduits, int segonsIntroduits)
        {
            if (horesIntroduides < 0 || horesIntroduides > 23 ||
                minutsIntroduits < 0 || minutsIntroduits > 59 ||
                segonsIntroduits < 0 || segonsIntroduits > 59)
            {
                return "Valors fora de rang (hores 0-23, minuts 0-59, segons 0-59)";
            }

            string inicial = $"{horesIntroduides:00}:{minutsIntroduits:00}:{segonsIntroduits:00}";

            int h = horesIntroduides;
            int m = minutsIntroduits;
            int s = segonsIntroduits;

            s += 1;
            if (s == 60)
            {
                s = 0;
                m += 1;
            }
            if (m == 60)
            {
                m = 0;
                h += 1;
            }
            if (h == 24)
            {
                h = 0;
            }

            string horaIncrementada = $"{h:00}:{m:00}:{s:00}";

            return $"Inicial: {inicial}\n+1s: {horaIncrementada}";
        }
    }
}
