namespace Ex05a
{
    internal class Program
    {
        /// <summary>
        /// Es considera que qualsevol nombre enter positiu n és perfecte si la suma dels seus divisors, excepte ell mateix, és igual a n. Per exemple, 6 és perfecte, ja que 6=1+2+3
        /// Donat un valor enter positiu introduït pel teclat, indicar si és perfecte o no.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int numeroCercat = int.Parse(Console.ReadLine());
            int divisorActual = 1;
            int sumaDivisors = 0;

            while ((numeroCercat > sumaDivisors) && (divisorActual <= numeroCercat / 2))
            {

                if (numeroCercat % divisorActual == 0)
                    sumaDivisors += divisorActual;

                divisorActual++;
            }

            if (sumaDivisors == numeroCercat)
            {
                Console.WriteLine(numeroCercat);
            }
        }
    }
}
