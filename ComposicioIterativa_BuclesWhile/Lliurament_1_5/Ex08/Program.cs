namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string NOM_FITXER = "Numeros.txt";

            StreamReader fitxerNumeros;

            fitxerNumeros = new StreamReader(NOM_FITXER);

            int numPetit;
            int numGran;

            Console.WriteLine("Introdueix un número");

            string strLinia = fitxerNumeros.ReadLine();
            if (strLinia != null)
            {
                int linia = int.Parse(fitxerNumeros.ReadLine());

                numGran = linia;
                numPetit = linia;
                strLinia = fitxerNumeros.ReadLine();

                while (strLinia != null)
                {
                    linia = int.Parse(fitxerNumeros.ReadLine());

                    if (linia > numGran)
                    {
                        numGran = linia;
                    }
                    else if (linia < numPetit)
                    {
                        numPetit = linia;
                    }

                    strLinia = fitxerNumeros.ReadLine();
                }

                Console.WriteLine($"De tots els nombres entrats, el més petit és {numPetit} i el més gran és {numGran}.");
            }

        }
    }
}
