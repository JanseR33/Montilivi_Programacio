namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Es farà una divisió de 2 nombres enters.");
            Console.WriteLine("Selecciona el valor d'A");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ara selecciona el valor de B");
            int y = Convert.ToInt32(Console.ReadLine());
            int resultat = Convert.ToInt32(x/y);
            int residu = Convert.ToInt32(x%y);
            Console.WriteLine($"El resultat de la divisió {x} / {y} dona com a resultat {resultat}, i com a residu queda {residu}");
        }
    }
}
