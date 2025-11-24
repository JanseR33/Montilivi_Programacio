using System.Globalization;
using System.Threading.Channels;

namespace Ex14
{
    internal class Program
    {
        /// <summary>
        ///  Donat el fitxer tiquetsuper.txt, calcular la el preu total de la compra del tiquet. La primera línia del fitxer indica el nombre de productes.
        ///  Després cada producte està format per tres línies (Nom del producte, Quantitat comprada de producte, Preu unitari del producte). El programa 
        ///  haurà d’indicar el preu final del tiquet.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string NOM_FITXER = "tiquetsuper.txt";
            StreamReader tiquetSuper;
            CultureInfo culture = new CultureInfo("es-ES");

            tiquetSuper = new StreamReader(NOM_FITXER);
            double preuTotal = 0;
            int contadorItems = Convert.ToInt32(tiquetSuper.ReadLine());

            for (int itemActual = 0; itemActual <= contadorItems; itemActual++)
            {
                string? nomProducte = tiquetSuper.ReadLine();
                int quantitatProducte = Convert.ToInt32(tiquetSuper.ReadLine());
                double preuProducte = Convert.ToDouble(tiquetSuper.ReadLine(), culture);

                double preuTotalItem = preuProducte * quantitatProducte;
                preuTotal += preuTotalItem;
            }
            tiquetSuper.Close();
            Console.WriteLine($"El preu total del tiquet és: {preuTotal}");
        }
    }
}
