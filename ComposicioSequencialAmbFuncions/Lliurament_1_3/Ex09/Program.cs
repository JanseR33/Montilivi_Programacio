namespace Ex09
{
    internal class Program
    {
        /// <summary>
        /// Demana a l'usuari introduir un radi i a partir d'això calcula el volum d'una esfera, l'àrea d'un cercle i el perímetre del cercle.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Aquest programa calcula el radi i el volum d'una esfera.");
            Console.WriteLine("Introdueix el valor del radi");
            double radiUser = double.Parse(Console.ReadLine());

            double volumResultat = CalcularVolumEsfera(radiUser);
            double areaResultat = CalcularAreaCercle(radiUser);
            double perimetreResultat = CalcularPerimetreCercle(radiUser);

            Console.WriteLine($"El volum de l'esfera és {volumResultat}");
            Console.WriteLine($"L'àrea del cercle és {areaResultat}");
            Console.WriteLine($"El perímetre del cercle és {perimetreResultat}");
        }

        /// <summary>
        /// Calcula el volum de l'esfera basant-se amb radi que hem introduït
        /// </summary>
        /// <param name="radi">Valor del radi introduït per l'usuari</param>
        /// <returns>Retorna el volum arrodonit amb 2 decimals</returns>
        static double CalcularVolumEsfera(double radi)
        {
            double volum = (4.0/3.0) * Math.PI * Math.Pow(radi, 3);
            
            return Math.Round(volum, 2);
        }

        /// <summary>
        /// Calcula l'àrea d'un cercle basant-se amb el radi introduït per l'usuari
        /// </summary>
        /// <param name="radi">El radi introduït per l'user</param>
        /// <returns></returns>
        static double CalcularAreaCercle(double radi)
        {
            double area = Math.PI * Math.Pow(radi, 2);
            return Math.Round(area, 2);
        }

        /// <summary>
        /// Calcula el perimetre del cercle utilitzant el radi 
        /// </summary>
        /// <param name="radi">Radi introduït per l'usuari.</param>
        /// <returns></returns>
        static double CalcularPerimetreCercle(double radi)
        {
            double perimetre = 2 * Math.PI * radi;

            return Math.Round(perimetre, 2);
        }
    }
}
