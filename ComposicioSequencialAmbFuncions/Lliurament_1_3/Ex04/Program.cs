using System.Text;

namespace Ex04
{
    internal class Program
    {
        /// <summary>
        /// Programa per convertir $ a €. Pregunta quants € son un 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Introdueix la quantitat de $ que vols passar a €");
            double dolarsEntrats = double.Parse(Console.ReadLine());
            Console.WriteLine("Ara introdueix el valor del $ en €");
            double valorDolar = double.Parse(Console.ReadLine());
            double eurosFinal = Calcul(dolarsEntrats, valorDolar);
            Console.WriteLine($"El resultat del canvi de moneda és de {eurosFinal}€");
        }

        /// <summary>
        /// Calcula els dolars per tornar-los euros
        /// </summary>
        /// <param name="dolarsEntrats">Son la quantitat de dolars entrats per l'usuari</param>
        /// <param name="valorDolar">És el valor del dolar que ha entrat l'usuari</param>
        /// <returns></returns>
        static double Calcul(double dolarsEntrats, double valorDolar)
        {
            double eurosFinal = dolarsEntrats * valorDolar;
            return eurosFinal;
        }
    }
}
