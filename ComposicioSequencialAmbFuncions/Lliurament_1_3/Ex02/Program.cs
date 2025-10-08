namespace Ex02
{
    internal class Program
    {
        /// <summary>
        /// La  distància  entre  dos  punts  en  el  pla 
        /// (x1,y1)  i  (x2,y2)  es  calcula  mitjançant  la següent fòrmula
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de distància");
            Console.WriteLine("Digues el primer valor d'x");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ara escriu el primer valor d'y");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ara, introdueix el segon valor d'x");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ara introdueix el segon valor d'y");
            double y2 = double.Parse(Console.ReadLine());

            double resultat = CalcDist(x1, y1, x2, y2);
            Console.WriteLine("El resultat final és:");
            Console.WriteLine($"{resultat:0.00}");
        }
        /// <summary>
        /// Calcula la distància entre diferents valors
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        public static double CalcDist(double x1, double y1, double x2, double y2)
        {
            double diferenciaX = Math.Pow(x2 - x1, 2);
            double diferenciaY = Math.Pow(y2 - y1, 2);
            double distancia = Math.Sqrt(diferenciaX + diferenciaY);
            return distancia;
        }
    }
}
