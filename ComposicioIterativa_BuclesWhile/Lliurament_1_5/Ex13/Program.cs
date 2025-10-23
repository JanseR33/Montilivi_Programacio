namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string NOM_FITXER = "bonus.txt";
            int import;
            int ticketBonus = 0;
            int ticketNoBonus = 0;
            StreamReader fitxerBonus;
            fitxerBonus = new StreamReader(NOM_FITXER);

            string bonusActual = fitxerBonus.ReadLine();

            while (bonusActual != null)
            {
                if (bonusActual == "BONUS")
                {
                    import = Random.Shared.Next(1, 11);
                    ticketBonus++;
                }
                else
                {
                    ticketNoBonus++;
                }

            }
            
        }
    }
}
