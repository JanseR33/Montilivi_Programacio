namespace Ex09
{
    internal class Program
    {
        /// <summary>
        /// Programa que al entrar un número enter positiu et diu quantes xifres té.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Entra un nombre enter i et diré quantes xifres té");

            int n = int.Parse(Console.ReadLine());

            int numFinal = n;
            int xifres = 0;

            while (numFinal > 0)
            {
                xifres++;
                numFinal /= 10;
            }

            Console.WriteLine($"Té {xifres} xifres.");
        }
    }
}
