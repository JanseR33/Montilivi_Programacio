namespace Saluda
{
    internal class Program
    /// <summary>
    /// Aquest programa demanarà el meu nom i em saludarà.
    /// </summary>
    /// <param name="args"></param>
    {
        static void Main(string[] args)
        {
    /// 
            Console.WriteLine("Com et dius?");
            string nom = Console.ReadLine();
            Console.WriteLine($"Hola, {nom}!");
        }
    }
}

            