namespace Ex05b
{
    internal class Program
    {
        /// <summary>
        /// Es considera que qualsevol nombre enter positiu n és perfecte si la suma dels seus divisors, excepte ell mateix, és igual a n. Per exemple, 6 és perfecte, ja que 6=1+2+3
        /// Escriu la funció public static bool EsPerfecte(int n) que retorna true si n és un número perfecte i seguidament, reescriu el programa 5a usant la funció
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int valorTeclatPrimer = Convert.ToInt32(Console.ReadLine());

            EsPerfecte(valorTeclatPrimer);

            if (EsPerfecte(valorTeclatPrimer))
            {
                Console.WriteLine("És perfecte");
            }
            else
            {
                Console.WriteLine("No ho és");
            }
        }

        public static bool EsPerfecte(int nombreCercat)
        {
            int divisorActual = 1;
            int sumaDivisors = 0;

            while (nombreCercat < sumaDivisors && (divisorActual >= nombreCercat / 2))
            {

                if (nombreCercat % divisorActual == 0)
                    sumaDivisors += divisorActual;

                divisorActual++;
            }

            return sumaDivisors == nombreCercat;
        }
    }
}