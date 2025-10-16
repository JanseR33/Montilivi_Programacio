namespace Ex13
{
    internal class Program
    {
        /// <summary>
        /// Aquesta aplicació mira si el nombre de 3 digits entrat és cap i cua
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueïx un nombre i et dirè si és cap i cua.");
            int n = int.Parse(Console.ReadLine());
            bool esCapICua = EsCapICua(n);

            if (esCapICua)
            {
                Console.WriteLine($"El número {n} és cap i cua.");
            }
            else
            {
                Console.WriteLine($"El número {n} no és cap i cua.");
            }
        }
        /// <summary>
        /// Aquesta funció revisa si és cap i cua.
        /// </summary>
        /// <param name="n">número entrat per l'usuari</param>
        /// <returns></returns>
        static public bool EsCapICua(int n)
        {
            int primerNum = n / 100;
            int tercerNum = n % 10;
            bool esCapICua = false;

            if (primerNum == tercerNum)
            {
                esCapICua = true;
            }

            return esCapICua;
        }
    }
}
