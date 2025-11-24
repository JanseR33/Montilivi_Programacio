namespace Ex13
{
    internal class Program
    {
        /// <summary>
        /// Considerem el fitxer Girona lliga23_24_v2.txt que conté resultats del Girona de la temporada 23/24 en un fitxer CSV.
        /// Realitza el mateix exercici que férem als recorreguts sabent que la primera entrada ens dirà el total de jornades de la lliga. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string NOM_FITXER = "Girona lliga23_24_v2.txt";
            StreamReader fitxerLliga;
            fitxerLliga = new StreamReader(NOM_FITXER);
            int golRival = 0, golGir = 0;
            int puntuacioTotal = 0;
            int partitsGuanyants = 0, partitsPerduts = 0, partitsEmpat = 0;

            int numeroPartits = Convert.ToInt32(fitxerLliga.ReadLine());

            for (int partitActual = 0; partitActual < numeroPartits; partitActual++)
            {
                string? lineaRival = fitxerLliga.ReadLine();
                golRival = Convert.ToInt32(lineaRival);

                string? lineaGir = fitxerLliga.ReadLine();
                golGir = Convert.ToInt32(lineaGir);

                if (golGir > golRival)
                {
                    partitsGuanyants++;
                    puntuacioTotal += 3;
                }
                else if (golGir < golRival) partitsPerduts++;
                else
                {
                    partitsEmpat++;
                    puntuacioTotal += 1;
                }
                
            }
            fitxerLliga.Close();
            Console.WriteLine($"el total de partits que han guanyat el Girona es de: {partitsGuanyants}");
            Console.WriteLine($"el total de partits que hna perdut el Girona es de: {partitsPerduts}");
            Console.WriteLine($"el total de partits que han enpatat el Girona es de es de: {partitsEmpat}");
            Console.WriteLine($"el total de punts fets del Girona es de {puntuacioTotal}");
        }
    }

}
