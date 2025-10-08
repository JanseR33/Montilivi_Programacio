namespace Ex07
{
    internal class Program
    {
        /// <summary>
        /// demana a l'usuari que introdueixi un número enter de 4 digits
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Escriu un nombre enter de 4 digits que es sumi");
            int numeroUsuari = int.Parse(Console.ReadLine());
            int resultatSuma = SumarDigits(numeroUsuari);
            Console.WriteLine($"Els numeros sumats donen com a resultat {resultatSuma}.");
        }

        /// <summary>
        /// Aquesta funció suma separa el valor de les unitats, desenes, centenes i milers i els suma entre si
        /// </summary>
        /// <param name="numero">numero es refereix al numero que ha entregat l'usuari</param>
        /// <returns></returns>
        static int SumarDigits(int numero)
        {
            int unitats = numero % 10;
            int desenes = (numero / 10) % 10;
            int centenes = (numero / 100) % 10;
            int milers = (numero / 1000);
            return (unitats + desenes + centenes + milers);
        }
    }
}
