namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string NOM_FITXER = "Numeros2.txt";

            int numElementsEntrats = 0;
            StreamReader fitxerNumeros;
            string linia;
            int suma = 0;

            fitxerNumeros = new StreamReader(NOM_FITXER);

            linia = fitxerNumeros.ReadLine();

            while (linia != null)
            {
                int n = int.Parse(linia);
                suma = suma + n;
                numElementsEntrats++;
                linia = fitxerNumeros.ReadLine();
            }
            int resultat = suma / numElementsEntrats;

            Console.WriteLine($"La mitja dels números dins del fitxer {NOM_FITXER} és de: {resultat}");
        }
    }
}