namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Programa que calcula de polzades a metres. 
            /// </summary>
            Console.WriteLine("Escriu la quantitat de polzades que passarem a metres");
            double polzadesEntrades = double.Parse(Console.ReadLine());
            double resultatMetres = Calcul(polzadesEntrades);
            Console.WriteLine($"{polzadesEntrades} polzades en metres son {resultatMetres}m");
        }

        static double Calcul(double polzadesEntrades)
        {
            /// <summary>
            /// Aqui hi ha la constant de quants cm son 1 polzada i quants cm hi ha en un metre.
            /// després fa el calcul 
            /// </summary>
            const double POLZADESCM = 2.54;
            const int CMENM = 100;

            double resultatMetres = (polzadesEntrades * POLZADESCM) / CMENM;
            return resultatMetres;
        }
    }
}
