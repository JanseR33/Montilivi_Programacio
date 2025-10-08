namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digues un any");
            int any = Convert.ToInt32(Console.ReadLine());
            int anyUnitats = any%10;
            int anyDesenes = (any/10) % 10;
            int anyCentenars = (any/100) % 10;
            int anyMilers = any/1000;
            Console.WriteLine($"{anyMilers}");
            Console.WriteLine($"{anyCentenars}");
            Console.WriteLine($"{anyDesenes}");
            Console.WriteLine($"{anyUnitats}");
        }
    }
}
