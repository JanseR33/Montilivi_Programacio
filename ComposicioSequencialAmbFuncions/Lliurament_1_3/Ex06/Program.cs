using System.Text;

namespace Ex06
{
    internal class Program
    {
        ///
        public static System.Text.Encoding UTF8 { get; }
        /// <summary>
        /// Aquest programa calcula el sou brut, el sou net i % d'impostos.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Benvingut al programa per calcular la teva nòmina");
            Console.WriteLine("Si us plau, entra les hores treballades");
            double horesTreballades = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ara, digues el sou brut per cada hora treballada");
            double souBrut = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("I ara, el percentatje de l'impost");
            int impostPercentatge = Convert.ToInt32(Console.ReadLine());
            double souBrutTotal = CalculSouBrutTotal(horesTreballades, souBrut);
            double impostFinal = CalculImpostos(impostPercentatge);
            double souNetTotal = CalculSouNet(impostFinal, souBrutTotal);
            Console.WriteLine($"El teu sou brut total és de {souBrutTotal}€ i la teva nòmina serà de {souNetTotal}€");


        }

        /// <summary>
        /// Aquesta funció calcula el sou brut total, multiplicant el sou brut per hora amb el total d'hores treballades.
        /// </summary>
        /// <param name="horesTreballades">Aquesta variable té el valor de les hores que han estat treballades</param>
        /// <param name="souBrut">Aquesta variable té el valor del que es cobra per hora en brut</param>
        /// <returns></returns>
        static double CalculSouBrutTotal(double horesTreballades, double souBrut)
        {
            double souBrutTotal = Convert.ToDouble(souBrut * horesTreballades);
            
            return souBrutTotal;
        }

        /// <summary>
        /// Aquesta funció calcula els impostos i els prepara per fer passar a net el sou brut total
        /// </summary>
        /// <param name="impostPercentatge">Aquesta variable conté l'impost en percentatge</param>
        /// <returns></returns>
        static double CalculImpostos(int impostPercentatge)
        {
            const int PERCENTATGE = 100;

            double impostFinal = Convert.ToDouble(impostPercentatge / PERCENTATGE);

            return impostFinal;
        }

        /// <summary>
        /// Aquesta funció treu el sou net total.
        /// </summary>
        /// <param name="impostFinal">l'impost final és el que està a punt per ser multiplicat per donar el valor final al sou net</param>
        /// <param name="souBrutTotal">Aquesta variable conté el sou brut total</param>
        /// <returns></returns>
        static double CalculSouNet(double impostFinal, double souBrutTotal)
            
        {
            double souNet = Convert.ToDouble(souBrutTotal * impostFinal);
            double souNetTotal = Convert.ToDouble(souBrutTotal - souNet);

            return souNetTotal;
        }
    }
}
