using System.Text;

namespace Ex11
{
    internal class Program
    {
        public static System.Text.Encoding UTF8 { get; }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Benvingut al programa per calcular la teva nòmina");
            Console.WriteLine("Si us plau, entra les hores treballades");
            double horesTreballades = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ara, digues el sou brut per cada hora treballada");
            double souBrut = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("I ara, el percentatje de l'impost");
            double impostPercentatge = Convert.ToDouble(Console.ReadLine());
            double impostFinal = Convert.ToDouble(impostPercentatge / 100);
            double souBrutTotal = Convert.ToDouble(souBrut * horesTreballades);
            double souNet = Convert.ToDouble(souBrutTotal * impostFinal);
            double souNetTotal = Convert.ToDouble(souBrutTotal - souNet);
            Console.WriteLine($"El teu sou brut total és de {souBrutTotal}€ i la teva nòmina serà de {souNetTotal}€");

        }
    }
}
