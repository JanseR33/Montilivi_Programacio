namespace Ex01
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa demani a l’usuari una quantitat d'hores, minuts i segons
        /// i ens informi per la consola del total de temps entrat, convertit tot en segons.
        /// El càlcul calfer-lo dissenyant una funció que rebi 3 paràmetres enters corresponents
        /// a les hores, minuts i segons i ens retorni un valor enter corresponent a la conversió a segons
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueix les hores:");
            int hores = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdueix els minuts:");
            int minuts = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdueix els segons:");
            int segons = int.Parse(Console.ReadLine());
            int totalSegons = ConvertSegons(hores, minuts, segons);
            Console.WriteLine($"El total de temps en segons és: {totalSegons}");
        }
        /// <summary>
        /// Aquesta funció calcula el número de segons que tenen unes hores
        /// minuts i segons prèviament proporcionats per l'usuari
        /// </summary>
        /// <param name="hores">Número d'hores</param>
        /// <param name="minuts">Número de minuts</param>
        /// <param name="segons">Número de segons</param>
        /// <returns>Retorna el número de segons </returns>
        static int ConvertSegons(int hores, int minuts, int segons)
        {
            return hores * 3600 + minuts * 60 + segons;
        }
    }
}
