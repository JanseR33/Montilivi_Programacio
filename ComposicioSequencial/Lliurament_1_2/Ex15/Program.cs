using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks.Dataflow;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Introdueix el canvi que s'ha de donar");
            double canvi = Convert.ToDouble(Console.ReadLine());
            int canviCentims = Convert.ToInt32(canvi * 100);
            int b100 = canviCentims / 10000; canviCentims %= 10000;
            int b50 = canviCentims / 5000; canviCentims %= 5000;
            int b20 = canviCentims / 2000; canviCentims %= 2000;
            int b10 = canviCentims / 1000; canviCentims %= 1000;
            int b5 = canviCentims / 500; canviCentims %= 500;
            int m2 = canviCentims / 200; canviCentims %= 200;
            int m1 = canviCentims / 100; canviCentims %= 100;
            int c50 = canviCentims / 50; canviCentims %= 50;
            int c20 = canviCentims / 20; canviCentims %= 20;
            int c10 = canviCentims / 10; canviCentims %= 10;
            int c5 = canviCentims / 5; canviCentims %= 5;
            int c2 = canviCentims / 2; canviCentims %= 2;
            int c1 = canviCentims; canviCentims = 0;

            if (b100 > 0) Console.WriteLine($"Bitllets de 100€: {b100}");
            if (b50 > 0) Console.WriteLine($"Bitllets de 50€: {b50}");
            if (b20 > 0) Console.WriteLine($"Bitllets de 20€: {b20}");
            if (b10 > 0) Console.WriteLine($"Bitllets de 10€: {b10}");
            if (b5 > 0) Console.WriteLine($"Bitllets de 5€: {b5}");
            if (m2 > 0) Console.WriteLine($"Monedes de 2€: {m2}");
            if (m1 > 0) Console.WriteLine($"Monedes de 1€: {m1}");
            if (c50 > 0) Console.WriteLine($"Monedes de 50 cènt: {c50}");
            if (c20 > 0) Console.WriteLine($"Monedes de 20 cènt: {c20}");
            if (c10 > 0) Console.WriteLine($"Monedes de 10 cènt: {c10}");
            if (c5 > 0) Console.WriteLine($"Monedes de 5 cènt: {c5}");
            if (c2 > 0) Console.WriteLine($"Monedes de 2 cènt: {c2}");
            if (c1 > 0) Console.WriteLine($"Monedes de 1 cènt: {c1}");
        }
    }
}
