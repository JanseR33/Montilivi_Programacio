using System.Numerics;

namespace Ex08
{
    internal class Program
    {
        /// <summary>
        /// demana a l'usuari una quantitat de segons que formatar
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueix la quantitat de segons que vols passar a hores, minuts i segons");
            int segonsUsuari = int.Parse(Console.ReadLine());
            string tempsFormatat = CalculHores(segonsUsuari);
            Console.WriteLine($"El temps formatat és: {tempsFormatat}");
        }
        /// <summary>
        /// Converteix els segons entrats a hores minuts i segons. Després retorna un string amb les hores minuts i segons
        /// </summary>
        /// <param name="totalSegons">la variable que conté tots els segons</param>
        /// <returns></returns>
        static string CalculHores(int totalSegons)
        {
            const int SEGONS_EN_HORES = 3600;
            const int SEGONS_EN_MINUTS = 60;

            int hores = totalSegons / SEGONS_EN_HORES;
            int segonsRestants = totalSegons % SEGONS_EN_HORES;
            int minuts = segonsRestants / SEGONS_EN_MINUTS;
            int segons = segonsRestants % SEGONS_EN_MINUTS;

            return $"{hores}:{minuts}:{segons}";
        }
    }
}
