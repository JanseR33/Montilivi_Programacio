namespace Ex11
{
    internal class Program
    {
        /// <summary>
        ///  Considerem el fitxer BONUS3.TXT per al càlcul del BONUS. 
        ///  La primera línia del fitxer conté el nombre total de bitllets. 
        ///  Cada línia només informa de si el bitllet té un "BONUS" o no. 
        ///  Si la línia té un "BONUS", la següent línia contindrà el valor "BONUS", i en cas contrari, "NO BONUS". 
        ///  Fes un programa que processi un fitxer de dades que contingui línies de “BONUS/NO BONUS”
        ///  en el format indicat i informi de quants bonus s'han distribuït, quants bitllets hi apareixen 
        ///  en el fitxer i quin percentatge de bitllets guanyadors hi ha respecte al total.
        ///  Ha d’indicar també quin és el guany obtingut amb els bonus trobats al fitxer.  
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string NOM_FITXER = "BONUS3.txt";

            StreamReader fitxerBonus;
            fitxerBonus = new StreamReader(NOM_FITXER);
            int nombreLinies = Convert.ToInt32(fitxerBonus.ReadLine());
            int valorBonus;
            int valorTotal = 0;
            int bonusDistribuits = 0;
            double percentatgeBonus;

            for (int contadorLinies=0; contadorLinies <= nombreLinies; contadorLinies++)
            {
                string esBonus = fitxerBonus.ReadLine();

                if (esBonus == "BONUS")
                {
                    valorBonus = Convert.ToInt32(fitxerBonus.ReadLine());
                    valorTotal += valorBonus;
                    bonusDistribuits++;
                    Console.WriteLine("La línea és bonus");
                }
                else Console.WriteLine("La línea NO és bonus");
            }
            fitxerBonus.Close();
            percentatgeBonus = (double)bonusDistribuits * 100 / (double)nombreLinies;

            Console.WriteLine($"En total, s'han distribuït {nombreLinies} bitllets.");
            Console.WriteLine($"D'aquests, {bonusDistribuits} eren bonus.");
            Console.WriteLine($"Això ens deixa en que un {percentatgeBonus:00}% d'aquests bitllets són bonus");
            Console.WriteLine($"El total de guanys ha estat de {valorTotal}");
        }
    }
}
