namespace Ex12
{
    internal class Program
    {
        /// <summary>
        /// Aquest programa agafa el fitxer alumnesDAMDAW.txt i compara si hi ha més ikers que Alex.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string NOM_FITXER = "alumnesDAMDAW.txt";

            StreamReader fitxerNom;
            int copsIker = 0;
            int copsAlex = 0;

            fitxerNom = new StreamReader(NOM_FITXER);

            string nom = fitxerNom.ReadLine();

            while (nom != null)
            {
                if (nom == "Iker")
                {
                    copsIker++;
                }
                else if (nom == "Alex")
                {
                    copsAlex++;
                }

                nom = fitxerNom.ReadLine();
            }

            if (copsAlex > copsIker)
            {
                Console.WriteLine($"Hi ha més alumnes que és diuen Alex que Iker {copsAlex} a {copsIker}.");
            }
            else if (copsAlex == copsIker) 
                Console.WriteLine("Han sortit el mateix número de cops");
            else
            {
                Console.WriteLine($"Hi ha més alumnes que és diuen Iker que Alex {copsIker} a {copsAlex}.");
            }
        }
    }
}
