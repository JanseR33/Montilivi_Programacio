namespace Ex06e
{
    internal class Program
    {
        /// <summary>
        /// Un nombre és primer si és divisible només per ell mateix i per 1.
        /// El 0 i l’ 1 es consideren no primers per definició.
        /// Escriu un programa per saber si un nombre positiu introduït pel teclat és primer o no.
        /// Escriu un programa que demani un valor n per teclat, i mostri per pantalla els n primers nombres primers.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Escriu el numero de nombres primers que vols trobar");
            int numerosATrovar = int.Parse(Console.ReadLine());
            int trovats = 0;
            int cont = 0;
            int numeroActual = 0;

            while (trovats != numerosATrovar)
            {

                for (int divisorActual = 1; divisorActual <= numeroActual; divisorActual++)
                {
                    if (numeroActual % divisorActual == 0)
                    {
                        cont++;
                    }
                }

                if (cont == 2)
                {
                    trovats++;
                    Console.WriteLine($"{numeroActual} es primari");
                }

                numeroActual++;
                cont = 0;
            }
        }
    }
}