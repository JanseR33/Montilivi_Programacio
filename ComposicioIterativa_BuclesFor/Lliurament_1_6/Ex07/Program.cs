namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            Console.WriteLine("entra un número");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                suma += i;
            }
            Console.WriteLine($"Tot sumat dona com a resultat {suma}");
        }
    }
}
