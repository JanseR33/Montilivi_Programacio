namespace Ex16
{
    internal class Program
    {
        /// <summary>
        /// L'antiga raça de Gulamatu està molt avançada en el seu esquema de càlcul d'anys.
        ///Entenen què és l'any de traspàs (Un any que és divisible per 4 i no divisible per 100 amb
        ///l'excepció que els anys que són divisibles per 400 també són anys de traspàs.) i també
        ///tenen anys de festa similars. Un és el festival Huluculu (succeeix en anys divisibles per
        ///15) i el festival Bulukulu (succeeix en anys divisibles per 55 sempre que també sigui un
        ///any de traspàs). Amb un any hauràs d'indicar quines propietats tenen aquests anys. Si
        ///l'any no és un any de traspàs ni un any de festival, imprimiu la línia "Aquest és un any
        ///normal". L'ordre d'impressió (si n'hi ha) de les propietats és any de
        ///traspàs-->huluculu-->bulukulu.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueïx l'any que vols saber si serà de traspàs, de Huluculu o de Bulukulu.");

            int any = int.Parse(Console.ReadLine());
            bool esAnyTraspas = EsAnyTraspas(any);
            bool esAnyFestivalHuluculu = EsAnyFestivalHuluculu(any);
            bool esAnyFestivalBulukulu = EsAnyFestivalBulukulu(any);

            if (!(esAnyTraspas || esAnyFestivalBulukulu || esAnyFestivalHuluculu)) Console.WriteLine("Aquest és un any normal");
            if (esAnyTraspas) Console.WriteLine("L'any entrat és de traspas.");
            if (esAnyFestivalHuluculu) Console.WriteLine("L'any entrat és del festival Huluculu.");
            if (esAnyFestivalBulukulu) Console.WriteLine("L'any entrat és del festival Bulukulu.");
        }

        /// <summary>
        /// Aquesta funció mira si l'any entrat és de traspàs
        /// </summary>
        /// <param name="any">És l'any entrat per l'usuari</param>
        /// <returns></returns>
        public static bool EsAnyTraspas(int any)
        {
            bool traspas = false;

            if ((0 == any % 4) && (any % 100 != 0) || (0 == any % 400))
            {
                traspas = true;
            }

            return traspas;
        }

        /// <summary>
        /// Aquesta funció mira si l'any entrat és del festival Huluculu
        /// </summary>
        /// <param name="any">És l'any entrat per l'usuari</param>
        /// <returns></returns>
        public static bool EsAnyFestivalHuluculu(int any)
        {
            bool festivalHuluculu = false;

            if (any % 15 == 0)
                festivalHuluculu = true;

            return festivalHuluculu;
        }
        /// <summary>
        /// Aquesta funció mira si l'any entrat és del festival Bulukulu
        /// </summary>
        /// <param name="any">És l'any entrat per l'usuari</param>
        /// <returns></returns>
        public static bool EsAnyFestivalBulukulu(int any)
        {
            bool festivalBulukulu = false;

            if (any % 55  == 0)
                festivalBulukulu = true;

            return festivalBulukulu;
        }
    }
}
