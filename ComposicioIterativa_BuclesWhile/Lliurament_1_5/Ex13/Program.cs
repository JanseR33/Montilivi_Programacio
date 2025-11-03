namespace Ex13
{
    internal class Program
    {
        /// <summary>
        /// Aquest programa mira el txt bonus.txt i diu si la linea es bonus o no. Després calcula un valor per l'etiqueta.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            const string NOM_FITXER = "bonus.txt";
            int import;
            int ticketBonus = 0;
            int ticketNoBonus = 0;
            int totalGuanys = 0;

            StreamReader fitxerBonus;
            fitxerBonus = new StreamReader(NOM_FITXER);

            string bonusActual = fitxerBonus.ReadLine();

            while (bonusActual != null)
            {
                if (bonusActual == "BONUS")
                {
                    import = Random.Shared.Next(1, 11);
                    totalGuanys += import;
                    ticketBonus++;
                }
                else if (bonusActual == "NO BONUS")
                {
                    ticketNoBonus++;
                }

                bonusActual = fitxerBonus.ReadLine();
            }

            fitxerBonus.Close();

            int totalTickets = ticketBonus + ticketNoBonus;

            double percentGuanyadors = 0.0;
            if (totalTickets > 0)
            {
                percentGuanyadors = ((double)ticketBonus / (double)totalTickets) * 100.0;
            }
            Console.WriteLine($"Bitllets totals: {totalTickets}");
            Console.WriteLine($"Bitllets amb BONUS: {ticketBonus}");
            Console.WriteLine($"Bitllets sense BONUS: {ticketNoBonus}");
            Console.WriteLine($"Percentatge guanyadors: {percentGuanyadors:00}%");
            Console.WriteLine($"Total de guanys: {totalGuanys}€");
        }
    }
}


