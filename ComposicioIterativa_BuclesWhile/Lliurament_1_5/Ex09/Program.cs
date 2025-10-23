namespace Ex09
{
    internal class Program
    {
        /// <summary>
        /// Programa que, donat un número enter positiu, diu quantes xifres té.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Entra un nombre enter positiu i et diré quantes xifres té");

            int n = int.Parse(Console.ReadLine());

            int numFinal = n;
            int xifres = 0;

            if (numFinal == 0)
            {
                xifres = 1;
            }
            else
            {
                while (numFinal > 0)
                {
                    xifres++;
                    numFinal /= 10;
                }
            }

            Console.WriteLine($"Té {xifres} xifres.");
        }
    }
}

