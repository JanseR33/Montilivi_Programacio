namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string NOM_FITXER = "Numeros.txt";

            int numElementsEntrats = 0;
            int elementActual = 0;
            StreamReader fitxerNumeros;
            string linia;

            fitxerNumeros = new StreamReader(NOM_FITXER);

            Console.WriteLine("Introdueix els elements fins acabar introduint un zero:");
            linia = fitxerNumeros.ReadLine();
            numElementsEntrats++;

            while (elementActual != null)
            {
                linia = fitxerNumeros.ReadLine();
                numElementsEntrats++;
            }

            Console.WriteLine($"El total de números entrats ha estat de {numElementsEntrats}");
        }
    }
}
