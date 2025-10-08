namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int SEGONSENHORES = 3600;
            const int SEGONSENMINUTS = 60;
            Console.WriteLine("Escriu un número en segons que transformar a hores minuts i segons");
            int totalSegons = Convert.ToInt32(Console.ReadLine());
            int hores = totalSegons / SEGONSENHORES;
            int minuts = (totalSegons % SEGONSENHORES) / SEGONSENMINUTS;
            int segons = totalSegons % SEGONSENMINUTS;
            Console.WriteLine($"Resultat (hh:mm:ss): {hores:00}:{minuts:00}:{segons:00}");
        }
    }
}
