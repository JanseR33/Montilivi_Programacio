namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            const string NOM_FITXER = "BONUS2.TXT";
            int import;
            int ticketBonus = 0;
            int ticketNoBonus = 0;
            int totalGuanys = 0;

            StreamReader fitxerBonus2;
            fitxerBonus2 = new StreamReader(NOM_FITXER);

            string bonusActual = fitxerBonus2.ReadLine();

            while (bonusActual != null)
            {
                if (bonusActual == "BONUS")
                {
                    string liniaQuantitat = fitxerBonus2.ReadLine();
                    import = int.Parse(liniaQuantitat);
                    totalGuanys += import;
                    ticketBonus++;
                }
                else if (bonusActual == "NO BONUS")
                {
                    ticketNoBonus++;
                }

                bonusActual = fitxerBonus2.ReadLine();
            }

            fitxerBonus2.Close();

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
