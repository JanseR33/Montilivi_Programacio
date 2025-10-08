namespace Ex03
{
    internal class Program
    {
        /// <summary>
        ///   Escriu un programa demani a l’usuari una quantitat d'hores, minuts i segons
        ///   i ens informi per la consola del total de temps entrat,convertit tot en segons. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueix les hores:");
            int hores = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdueix els minuts:");
            int minuts = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdueix els segons:");
            int segons = Convert.ToInt32(Console.ReadLine());
            int totalSegons = hores * 3600 + minuts * 60 + segons;
            Console.WriteLine($"L'hora entrada ha estat {hores}:{minuts}:{segons}, que en segons és: {totalSegons} segons.");
        }
    }
}
