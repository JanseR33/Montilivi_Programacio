namespace Ex06
{
    internal class Program
    {
        /// <summary>
        /// Aquest programa demana 10 núms i després mira quants son positius, negatius i 0.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Declaro les variables
            int numPositiu = 0;
            int numNegatiu = 0;
            int copsZero = 0;

            int num;
            Console.WriteLine("entra 10 números");

            for (num = 1; num <= 10; num++)
            {
                Console.Write($"Entra el nombre número {num}: ");
                int valorUsuari = int.Parse(Console.ReadLine());

                if (valorUsuari > 0)
                    numPositiu++;
                else if (valorUsuari == 0)
                    copsZero++;
                else numNegatiu++;
            }

            // Línia en blanc per estètica
            Console.WriteLine(" ");
            if (numPositiu > 0) Console.WriteLine($"Números positius entrats: {numPositiu}");
            if (numNegatiu > 0) Console.WriteLine($"Números negatius entrats: {numNegatiu}");
            if (copsZero > 0) Console.WriteLine($"Zeros entrats: {copsZero}");
        }
    }
}
