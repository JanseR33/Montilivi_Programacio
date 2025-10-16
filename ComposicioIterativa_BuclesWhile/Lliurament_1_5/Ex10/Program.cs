namespace Ex10
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa on llancem un dau de 6 cares (valors de forma aleatoria)
        /// fins que el número de vegades que surti 1 i 6 sigui el mateix.
        /// Conta quantes vegades hem llançat el dau i quantes vegades ha aparegut el valor 6. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            int quantitat1 = 0;
            int quantitat6 = 0;
            int quantitatD6Llançats = 0;
            Console.WriteLine("Aquest programa llença un dau de 6 cares i diu quants cops ha caigut en 1 i quants en 6.");
            int d6;

            while (!((quantitat1 != quantitat6) && (quantitat1 != 0) && (quantitat6 != 0)))
            {
                quantitatD6Llançats++;
                d6 = Random.Shared.Next(1, 7);
                if (d6 == 1)
                {
                    quantitat1++;
                }
                else if (d6 == 6)
                {
                    quantitat6++;
                }
            }

            Console.WriteLine($"La quantiatat de cops que s'ha llençat el D6 és de {quantitatD6Llançats}, mentre que la quantitat de 6 que han sortit ha estat de {quantitat6}");
        }
    }
}
