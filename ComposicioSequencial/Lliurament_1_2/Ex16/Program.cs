using System.Security.Cryptography;

namespace Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Escriu un programa que ens mostri el resultat aleatori
            /// del partit Paris Sant Germain - Girona de forma que
            /// tant el valor dels gols d’un com de l’altre equip sigui un valor a l’atzar entre 0 i 6. 
            /// </summary>
            Console.WriteLine("Hello, World!");
            int golGir = Random.Shared.Next(0, 7);
            int golPSG = Random.Shared.Next(0, 7);
            Console.WriteLine("Resultat aleatori del partit:");
            Console.WriteLine($"Paris Saint Germain {golPSG} - {golGir} Girona");
            if (golGir > golPSG)
                Console.WriteLine("Ha guanyat el Girona");
            else if (golGir < golPSG)
                Console.WriteLine("Ha guanyat el PSG");
            else Console.WriteLine("Han empatat");
        }
    }
}
