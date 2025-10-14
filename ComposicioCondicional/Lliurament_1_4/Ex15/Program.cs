namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introdudix les hores");
            int horesIntroduides = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("introdueix els minuts");
            int minutsIntroduits = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("introdueix els segons que li vulguem sumar");
            int segonsIntroduits = Convert.ToInt32(Console.ReadLine());

            string resultat = AfegirSegonsAMinutsIHores(horesIntroduides, minutsIntroduits, segonsIntroduits);

            Console.WriteLine(resultat);
        }

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