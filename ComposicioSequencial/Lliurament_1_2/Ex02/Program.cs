namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quina edat tens?");
            int edat = Convert.ToInt32(Console.ReadLine());
            edat = edat + 1;
            Console.WriteLine($"L'any que ve tindràs { edat} anys.");
        }
    }
}
