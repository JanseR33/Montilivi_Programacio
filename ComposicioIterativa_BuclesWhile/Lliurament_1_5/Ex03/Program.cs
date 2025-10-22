namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valPositiu = 0;
            int valNegatiu = 0;

            Console.WriteLine("Introdueix Números i et dirè quants n'has posat de positius i quants de negatius." +
                " S'aturarà quan escriguis 0");
            int numActual = int.Parse(Console.ReadLine());
            
            while (numActual != 0)
            {
                if (numActual > 0)
                {
                    valPositiu++;
                }
                else
                {
                    valNegatiu++;
                }

                numActual = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"El total de números positius entrats ha estat {valPositiu}, mentre que el negatiu han estat de {valNegatiu}");
        }
    }
}
