namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplicacio = 1;
            Console.WriteLine("entra un número");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                multiplicacio *= i;
            }
            Console.WriteLine($"Tot dona com a resultat {multiplicacio}");
        }
    }
}
