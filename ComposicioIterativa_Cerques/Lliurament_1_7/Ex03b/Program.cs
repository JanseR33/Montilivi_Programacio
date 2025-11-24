namespace Ex03b
{
    internal class Program
    {
        /// <summary>
        /// Donada una seqüència d’enters, indicar si hi ha algun número parell.
        /// Versió 2: La seqüència prové del teclat i acaba amb-9999.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const int CONDICIO_FI = -9999;

            bool condicioCompletada = false;
            int numActual = int.MaxValue;

            Console.WriteLine("Entra nombres i et diré si és parell o no. Per parar de mirar nombres, escriu -9999");
            while (numActual != CONDICIO_FI && numActual %2 != 0)
            {
                numActual = int.Parse(Console.ReadLine());
            }

            if (numActual == CONDICIO_FI)
            {
                Console.WriteLine("Has acabat el programa sense escriure cap nombre parell.");
            }
            else
            {
                Console.WriteLine($"Hi havia un número parell");
            }
        }
    }
}
