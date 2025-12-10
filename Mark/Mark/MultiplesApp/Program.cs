namespace MultiplesApp
{
    public class Program
    {
        /// <summary>
        /// Aquesta aplicació mira si un número és múltiple de 2, de 7, dels 2 o de cap.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueix un número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            bool esMultipleDe2 = EsMultipleDe2(numero);
            bool esMultipleDe7 = EsMultipleDe7(numero);

            if (esMultipleDe2 && esMultipleDe7)
            {
                Console.WriteLine("El número és múltiple de 2 i de 7");
            }
            else if (esMultipleDe2)
            {
                Console.WriteLine("El número és múltiple de 2");
            }
            else if (esMultipleDe7)
            {
                Console.WriteLine("El número és múltiple de 7");
            }
            else
            {
                Console.WriteLine("El número no és múltiple de 2 ni de 7");
            }
        }

        /// <summary>
        /// Determina si és multiple de 2 o no
        /// </summary>
        /// <param name="numero">Agafa el num introduït per l'usuari</param>
        /// <returns></returns>
        public static bool EsMultipleDe2(int numero)
        {
            if (numero % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Determina si és multiple de 7 o no
        /// </summary>
        /// <param name="numero">Agafa el num introduït per l'usuari</param>
        /// <returns></returns>
        public static bool EsMultipleDe7(int numero)
        {
            if (numero % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
