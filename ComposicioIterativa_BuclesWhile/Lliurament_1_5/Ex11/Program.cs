namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iteracions = 0;
            bool acabat = false;

            while (!acabat)
            {
                int num1 = Random.Shared.Next(1, 101);
                int num2 = Random.Shared.Next(1, 101);

                Console.WriteLine($"Els nombres que han sortit són {num1} i {num2}.");

                Console.WriteLine("Ara digues el resultat de la suma d'aquests.");
                int resultatSumaUsuari = int.Parse(Console.ReadLine());

                if (resultatSumaUsuari != num1 + num2)
                {
                    Console.WriteLine("T'has equivocat, tornem a començar tot!");
                    iteracions++;
                    continue;
                }
                Console.WriteLine("El resultat és correcte");

                Console.WriteLine("Ara fes la resta");
                int resultatRestaUsuari = int.Parse(Console.ReadLine());

                if (resultatRestaUsuari != num1 - num2)
                {
                    Console.WriteLine("T'has equivocat, tornem a començar tot!");
                    iteracions++;
                    continue;
                }
                Console.WriteLine("El resultat és correcte");

                Console.WriteLine("Ara calcula el producte");
                int resultatProducteUsuari = int.Parse(Console.ReadLine());

                if (resultatProducteUsuari != num1 * num2)
                {
                    Console.WriteLine("T'has equivocat, tornem a començar tot!");
                    iteracions++;
                    continue;
                }
                Console.WriteLine("El resultat és correcte");

                Console.WriteLine("Ara calcula la divisió entera");
                int resultatDivisioUsuari = int.Parse(Console.ReadLine());

                if (resultatDivisioUsuari != num1 / num2)
                {
                    Console.WriteLine("T'has equivocat, tornem a començar tot!");
                    iteracions++;
                    continue;
                }
                Console.WriteLine("El resultat és correcte");

                iteracions++;
                acabat = true;
            }

            Console.WriteLine($"Has necessitat {iteracions} iteracions per encertar totes les operacions.");
        }


    }
}
