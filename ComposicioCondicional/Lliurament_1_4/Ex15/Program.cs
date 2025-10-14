namespace Ex15
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa per tal de sumar un segon a una hora,minut i segon entrat per teclat.
        /// El programa demanarà separadament les hores, minuts i segons i mostrarà tant l’hora entrada inicialment,
        /// com l’hora incrementada en un segon. Cal mostrar en format hh:mm:ss.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("introdudix les hores");
            int horesIntroduides = int.Parse(Console.ReadLine());

            Console.WriteLine("introdueix els minuts");
            int minutsIntroduits = int.Parse(Console.ReadLine());

            Console.WriteLine("introdueix els segons que desitgem sumar");
            int segonsIntroduits = int.Parse(Console.ReadLine());

            string resultat = AfegirSegonsAMinutsIHores(horesIntroduides, minutsIntroduits, segonsIntroduits);

            Console.WriteLine(resultat);
        }
        /// <summary>
        /// En aquesta funció es fà el càlcul.
        /// </summary>
        /// <param name="horesIntroduides">Aquest és el valor de les hores introduïdes per l'usuari</param>
        /// <param name="minutsIntroduits">Aquest és el valor de les minuts introduïts per l'usuari</param>
        /// <param name="segonsIntroduits">Aquest és el valor de les segons introduïts per l'usuari</param>
        /// <returns></returns>
        static string AfegirSegonsAMinutsIHores(int horesIntroduides, int minutsIntroduits, int segonsIntroduits)
        {
            int segonsSobrants;
            int minutsSobrants;
            string resultat;

            if (horesIntroduides <= 24 && minutsIntroduits <= 59)
            {
                if (segonsIntroduits < 60)
                {
                    segonsSobrants = segonsIntroduits;
                }
                else
                {
                    minutsIntroduits += (minutsIntroduits + segonsIntroduits) / 60;
                    segonsSobrants = segonsIntroduits % 60;
                    Console.WriteLine(minutsIntroduits + " " + segonsSobrants);
                }

                if (minutsIntroduits > 60)
                {
                    minutsSobrants = minutsIntroduits;
                }
                else
                {
                    horesIntroduides += (horesIntroduides + minutsIntroduits) / 60;
                    minutsSobrants = minutsIntroduits % 60;
                    Console.WriteLine(horesIntroduides + " " + minutsSobrants);
                }

                if (horesIntroduides > 24)
                {
                    resultat = ($"t'has pasat de les 24: {horesIntroduides}:{minutsSobrants}:{segonsSobrants}");
                }

                resultat = ($"{horesIntroduides}:{minutsSobrants}:{segonsSobrants}");
                return resultat;
            }
            else
            {
                resultat = ($"apren a posar una hora");
                return resultat;
            }
        }
    }
}