namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FITX_TROB = "TROBAT.txt";
            const string FITX_PERD = "PERDUT.txt";
            const int CONDICIO = 231;

            StreamReader lectorFitxers = new StreamReader(FITX_TROB);

            string? linea = lectorFitxers.ReadLine();
            int posicioActual = 0;
            int numCiclista = 0;

            while (linea != null && numCiclista != CONDICIO)
            {
                numCiclista = int.Parse(linea);
                posicioActual++;
                linea = lectorFitxers.ReadLine();
            }

            if (linea == null)
            {
                Console.WriteLine("El ciclista s'ha perdut.");
            }
            else
            {
                Console.WriteLine($"El ciclista número 231 ha arribat a la meta en la posició {posicioActual}");
            }
        }
    }
}
