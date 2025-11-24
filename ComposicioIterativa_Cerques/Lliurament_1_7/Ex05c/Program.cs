namespace Ex05c
{
    internal class Program
    {
        /// <summary>
        /// Es considera que qualsevol nombre enter positiu n és perfecte si la suma dels seus divisors, excepte ell mateix, és igual a n. Per exemple, 6 és perfecte, ja que 6=1+2+3
        /// Donada una seqüència de valors procedents d’un fitxer, informar per a cada valor, si és perfecte o no (CERCA O RECORREGUT?).
        /// Usar el fitxer PERFECTES.TXT que conté el 33550336 que és perfecte i el 6 que també és perfecte.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string NOM_FITXER = "PERFECTES.txt";
            StreamReader lectorPerfectes = new StreamReader("PERFECTES.txt");

            int divisorActual = 1;
            int sumaDivisors = 0;
            int num;
            string? linea;

            while ((linea = lectorPerfectes.ReadLine()) != null)
            {
                num = int.Parse(linea);
                while (num > sumaDivisors && (divisorActual <= (num / 2)))
                {
                    if (num % divisorActual == 0)
                        sumaDivisors += divisorActual;

                    divisorActual++;
                }

                if (sumaDivisors == num)
                {
                    Console.WriteLine($"{num} És perfecte");
                }
                else
                {
                    Console.WriteLine($"{num} No ho és");
                }
                sumaDivisors = 0;
                divisorActual = 1;
            }
        }
    }
}