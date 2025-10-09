namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string NOM_FITXER = "../Fitxers/Numeros.txt";

            int numElementsEntrats = 0;
            int elementActual = 0;
            StreamReader fitxerNumeros;

            fitxerNumeros = new StreamReader(NOM_FITXER);

            Console.WriteLine("Introdueix els elements fins acabar introduint un zero:");
            elementActual = int.Parse(Console.ReadLine());
            numElementsEntrats++;

            while (elementActual != 0)
            {
                elementActual = int.Parse(Console.ReadLine());
                numElementsEntrats++;
            }

            Console.WriteLine($"El total de números entrats ha estat de {numElementsEntrats}");
        }
    }
}
