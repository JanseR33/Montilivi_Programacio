namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string NOM_FITXER = "Numeros.txt";

            int valPositiu = 0;
            int valNegatiu = 0;
            StreamReader fitxerNumeros;
            string linia;

            fitxerNumeros = new StreamReader(NOM_FITXER);

            linia = fitxerNumeros.ReadLine();

            while (linia != null)
            {
                int n = int.Parse(linia);
                if (n >= 0)
                {
                    valPositiu++;
                }
                else
                {
                    valNegatiu++;
                }
                linia = fitxerNumeros.ReadLine();
            }

            fitxerNumeros.Close();

            Console.WriteLine($"Dels números que conté el fitxer {NOM_FITXER}:");
            Console.WriteLine($"{valPositiu} son positius");
            Console.WriteLine($"{valNegatiu} son negatius");
        }
    }
}
