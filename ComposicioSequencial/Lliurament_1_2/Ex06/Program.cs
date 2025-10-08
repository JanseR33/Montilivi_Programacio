namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int distanciaMinMaj = 32;
            Console.WriteLine("Escriu una lletra minúscula");
            char lletraMinuscula = Convert.ToChar(Console.ReadLine());
            int asciiMinuscula = Convert.ToInt32(lletraMinuscula);
            int asciiMajuscula = asciiMinuscula - distanciaMinMaj;
            char lletraMajuscula = Convert.ToChar(asciiMajuscula);
            Console.WriteLine($"La lletra {lletraMinuscula} en majúscula és {lletraMajuscula}.");
        }
    }
}
