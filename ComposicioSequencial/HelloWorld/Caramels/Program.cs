namespace Caramels
{
    internal class Program
    {
        /// <summary>
        /// Cal repartir uns caramels entre els alumnes
        /// Ha de demanar quants caramels hi ha i quants alumnes
        /// Ha de dir quants caramels li toquen a cada alumne
        /// i quants li queden al professor
        /// </summary>
        /// <param name="args"></param>"
        static void Main(string[] args)
        {
            int caramels, alumnes, caramelsPerAlumne, caramelsRestants, professor = 1;
            Console.WriteLine("Quants caramels hi ha?");
            caramels = int.Parse(Console.ReadLine());
            if (caramels <= 0)
            {
                Console.WriteLine("El nombre de caramels no pot ser ni negatiu ni zero");
                return;
            }
            Console.WriteLine("Quants alumnes hi ha?");
            alumnes = int.Parse(Console.ReadLine());
            if (alumnes <= 0)
            {
                Console.WriteLine("El nombre d'alumnes ha de ser positiu");
                return;
            }
            caramelsPerAlumne = caramels / alumnes + professor;
            caramelsRestants = caramels % alumnes;
            Console.WriteLine($"A cada alumne li toquen {caramelsPerAlumne} caramels.");
            Console.WriteLine($"Al professor li queden {caramelsRestants} caramels.");
        }
    }
}

