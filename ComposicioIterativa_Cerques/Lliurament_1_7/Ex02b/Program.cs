namespace Ex02b
{
    internal class Program
    {
        /// <summary>
        /// Donada una seqüència d’enters, informar si el primer valor es repeteix. Podem considerar un número per línia.
        /// Versió 2: La seqüència prové del teclat i acaba amb-9999.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const int CONDICIO_FI = -9999;

            bool condicioCompletada = false;
            int numActual = 0;

            Console.WriteLine("Entra un nombre i després mira si repeteixes el mateix.");
            int numEntratUsuari = int.Parse(Console.ReadLine());
            Console.WriteLine("Ara entra números números fins que repeteixis el primer o fins que escriguis -9999");
            while (numActual != CONDICIO_FI && condicioCompletada == false)
            {
                numActual = int.Parse(Console.ReadLine());

                if (numEntratUsuari == numActual)
                {
                    condicioCompletada = true;
                }
            }

            if (condicioCompletada == true)
            {
                Console.WriteLine($"Has repetit el número {numEntratUsuari}");
            }
            else
            {
                Console.WriteLine("Has acabat el programa sense repetir el número.");
            }
        }
    }
}
