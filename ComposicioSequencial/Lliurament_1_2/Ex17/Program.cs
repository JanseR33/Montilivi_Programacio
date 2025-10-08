namespace Ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Aquest programa és un RNG
            /// </summary>
            Console.WriteLine("Cuantes cares té el teu dau");
            int caresDau = Convert.ToInt32(Console.ReadLine());
            int resultat = Random.Shared.Next(1, caresDau++);
            Console.WriteLine($"Ha sortit {resultat}");
        }
    }
}
