namespace Ex03
{
    internal class Program
    {
        /// <summary>
        /// Demana una lletra minuscula per ser transformada a majuscula
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Posa una lletra minuscula");
            char lletraMin = Convert.ToChar(Console.ReadLine());
            char resultat = Transformacio(lletraMin);
            Console.WriteLine($"la lletra és {resultat}");
        }
        /// <summary>
        /// Transforma de minúscula a majúscula
        /// </summary>
        /// <param name="lletraMin">És la lletra minuscula entrada per l'user</param>
        /// <returns></returns>
        public static char Transformacio(char lletraMin)
        {
            const int MINUSCULA_TO_MAJUSCULA = 'a'-'A';
            int lletraMinNum = (int)lletraMin;
            int lletraMajNum = lletraMinNum - MINUSCULA_TO_MAJUSCULA;
            char lletraMajResult = Convert.ToChar(lletraMajNum);

            return lletraMajResult;
        }
    }
}
