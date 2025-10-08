namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aquesta línea escriu un text en la consol·la
            Console.WriteLine("Si us plau, introdueix un nombre enter:");
            //Aquesta crea la variable n i registra el número que premi l'usuari
            int n = Convert.ToInt32(Console.ReadLine());
            //Aquesta suma 1 a n
            n = n + 1;
            //
            Console.WriteLine($"HAS ENTRAT: { n - 1} I UN MÉS VAL { n}");
            Console.WriteLine($"HAS ENTRAT: { n - 1:0000} I UN MÉS VAL { n:0000}");
        }
    }
}
