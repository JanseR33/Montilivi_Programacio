using System;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueix una hora");
            int hora = int.Parse(Console.ReadLine());
            bool esValida = HoraValida(hora);
            if (esValida == true)
                Console.WriteLine($"L'hora entrada és possible");
            else Console.WriteLine($"L'hora entrada no és possible");
        }
        public static bool HoraValida(int hora)
        {
            int h = hora / 10000;
            int m = (hora / 100) % 100;
            int s = hora % 100;

            bool hPossible = false;
            bool mPossible = false;
            bool sPossible = false;

            if (h >= 0 && h < 24)
            {
                hPossible = true;
            }

            if (m >= 0 && m < 60)
            {
                mPossible = true;
            }

            if (s >= 0 && s < 60)
            {
                sPossible = true;
            }

            if (hPossible == false || mPossible == false || sPossible == false)
            {
                return false;
            }
            else { return true; }
        }
    }
}
