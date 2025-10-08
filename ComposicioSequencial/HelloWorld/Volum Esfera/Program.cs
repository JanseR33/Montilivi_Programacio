namespace Volum_Esfera
{
    internal class Program
    {
        /// <summary>
        /// Programa que et demana el radi d'una esfera en metres i calcula el seu volum (4/3*pi*r*r*r)
        /// Compte que té una errada. La saps trobar
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const double PI = 3.14159;
            double radi, volum;
            Console.WriteLine("RADI DE L'ESFERA EN METRES ? ");
            radi = Convert.ToDouble(Console.ReadLine());
            volum = 4.0 / 3.0 * PI * Math.Pow(radi, 3);
            Console.WriteLine($"ESFERA DE RADI {radi} TÉ UN VOLUM DE {volum} m3");
        }
    }
}
