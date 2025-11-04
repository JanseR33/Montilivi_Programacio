namespace Ex01
{
    internal class Program
    {
        /// <summary>
        /// Escriu els primers 20 números
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num1;

            for (num1 = 0; num1 <= 20; num1++)
            {
                // poso aquest if perquè m'agrada més que hi hagi comes mentres s'esperen més nombres.
                if (num1 <= 19)
                    Console.WriteLine($"{num1},");
                else
                    Console.WriteLine($"{num1}.");
            }
        }
    }
}
