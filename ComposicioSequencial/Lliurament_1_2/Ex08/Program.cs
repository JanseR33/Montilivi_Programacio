using System.Text;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Converteix de $ a €");
            Console.WriteLine("Introdueix quants € són un $");
            double valorEuro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("I ara digues quants $ vols passar a €");
            double dolars = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El total d'€ que tindràs amb {dolars}$ serà de {dolars * valorEuro:0.00}€");
        }
    }
}
