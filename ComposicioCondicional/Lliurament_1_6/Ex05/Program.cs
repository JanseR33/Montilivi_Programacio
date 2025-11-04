namespace Ex05
{
    internal class Program
    {
        /// <summary>
        /// Aquest programa suma el número entrat per l'usuari.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int suma = 0;
            int num;
            Console.WriteLine("entra 10 números");

            for (num = 1; num <= 10; num++)
            {
                Console.Write($"Entra el nombre número {num}: ");
                int valorUsuari = int.Parse(Console.ReadLine());

                if (suma == 0)
                {
                    Console.WriteLine($"{valorUsuari}");
                    suma += valorUsuari;
                }
                else
                {
                    Console.Write($"{suma} + {valorUsuari} = ");
                    suma += valorUsuari;
                    Console.WriteLine($"{suma}");
                }

                // EXTREMADAMENT IMPORTANT NO DEIXAR AIXÒ EN LA VERSIÓ FINAL!!!!!
                if (suma == 67)
                    Console.WriteLine("HAHAHAHAHAHAHHAAH 67 SIX SEVEN HAHAHAHAHHAHAHAAHAAH SIIIIX SEVEEEEEEEEN AAAAAAAAAAAAAHHAHAHAHAHAHAHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            }
        }
    }
}
