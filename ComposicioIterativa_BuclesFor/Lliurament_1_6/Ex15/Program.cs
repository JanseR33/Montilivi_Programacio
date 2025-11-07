namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const char CARACTER = '*';
            int alçada = 0;
            int amplada = 0;
            Console.Write("Escriu l'amplada del rectangle: ");
            amplada = int.Parse(Console.ReadLine());
            Console.Write("Escriu l'alçada del rectangle: ");
            alçada = int.Parse(Console.ReadLine());

            for (int nLinia = 0; nLinia < alçada; nLinia++)
            {
                for (int nColumna = 0; nColumna < amplada; nColumna++)
                {
                    Console.Write(CARACTER);
                }
                Console.WriteLine();
            }
        }
    }
}
