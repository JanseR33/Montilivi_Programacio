namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Aquest programa demana a l'usuari dos nombres enters i intercanvia els seus valors.
            /// </summary>
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
