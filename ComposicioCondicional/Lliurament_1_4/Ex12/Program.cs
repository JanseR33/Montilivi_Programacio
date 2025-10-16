namespace Ex12
{
    internal class Program
    {
        /// <summary>
        /// Programa que calcula si un any és de traspas o no.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int any;
            bool resultat;

            Console.WriteLine("Escriu un any i et diré si és de traspàs.");
            any = Convert.ToInt32(Console.ReadLine());

            resultat = Traspas(any);

            if (resultat == true)
            {
                Console.WriteLine($"L'any {any} es de traspàs");
            }
            else if (resultat == false)
            {
                Console.WriteLine($"L'any {any} no es de traspàs");
            }
        }
        /// <summary>
        /// Funció que calcula si l'any és de traspàs.
        /// </summary>
        /// <param name="any">any entrat per l'user</param>
        /// <returns></returns>
        public static bool Traspas(int any)
        {
            bool trespas = false;

            if ((0 == any % 4) && (any % 100 != 0) || (0 == any % 400))
            {
                trespas = true;
            }

            return trespas;
        }
    }
}