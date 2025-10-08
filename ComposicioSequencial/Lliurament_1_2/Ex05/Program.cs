namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriu una lletra");
            char lletra = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"El valor Ascii de la {lletra} és {Convert.ToInt32(lletra)}");
        }
    }
}
