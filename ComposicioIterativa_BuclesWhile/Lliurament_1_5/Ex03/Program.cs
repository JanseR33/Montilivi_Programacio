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
            int n = int.Parse(Console.ReadLine());
            
            while (n != 0)
            {
                if (n > 0)
                {
                    valPositiu++;
                }
                else
                {
                    valNegatiu++;
                }

                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"El total de números positius entrats ha estat {valPositiu}, mentre que el negatiu han estat de {valNegatiu}");
        }
    }
}
