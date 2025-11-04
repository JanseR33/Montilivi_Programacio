namespace Ex02
{
    internal class Program
    {
        /// <summary>
        /// Aquest programa escriu els primers 20 nombres parells
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num;
            // No vull fer una lògica que revisa si el nombre és parell o no, per tant, vaig de 2 en 2.
            for(num=2; num <= 40; num = num + 2 )
            {

                if (num <= 38)
                    Console.WriteLine($"{num},");
                else
                    Console.WriteLine($"{num}.");
            }
        }
    }
}
