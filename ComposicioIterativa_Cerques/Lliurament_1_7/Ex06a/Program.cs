namespace Ex06a
{
    internal class Program
    {
        /// <summary>
        /// Un nombre és primer si és divisible només per ell mateix i per 1. El 0 i l’ 1 es consideren no primers per definició.
        /// Escriu un programa per saber si un nombre positiu introduït pel teclat és primer o no.
        /// Donat un valor enter positiu introduït pel teclat, indicar si és primer o no.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int cont = 0;
            int divisorActual = 2;
            Console.WriteLine("Escriu un valor enter i et dirè si és primer.");
            int numEntrat = int.Parse(Console.ReadLine());
            while (divisorActual <= numEntrat / 2 && numEntrat % divisorActual !=0 )
            {
                numEntrat = int.Parse(Console.ReadLine());
            }

            if (divisorActual >= numEntrat)
            {
                Console.WriteLine($"El nombre {numEntrat} és primer");
            }
            else
            {
                Console.WriteLine($"El nombre {numEntrat} no és primer");
            }
        }
    }
}
