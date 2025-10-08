namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int PEUSPOLZADES = 12;
            const double METRESPOLZADES = 39.37;

            Console.WriteLine("Ara passarem de peus a metres");
            Console.WriteLine("Digues quants peus desitges passar a metres");
            double peus = Convert.ToDouble(Console.ReadLine());
            double metres = Convert.ToDouble((peus*PEUSPOLZADES)/METRESPOLZADES);
            Console.WriteLine($"Els peus convertits a metres donen un total de {metres:0.00}m");
        }
    }
}
