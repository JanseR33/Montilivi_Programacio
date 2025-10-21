namespace Ex11
{
    internal class Program
    {
        /// <summary>
        /// Aquest programa dona 2 nombres aleatoris de l'1 al 100 i et fa sumar-los, restar-los, mulitplicar-los i dividir-los. Si t'equivoques, tornes a començar amb 2 nombres
        /// aleatoris nous. Després, et diu quants cops t'has equivocat.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool esCorrecte = false;
            int num1;
            int num2;
            int iteracions = 0;

            while (esCorrecte == false)
            {
                num1 = Random.Shared.Next(1, 101);
                num2 = Random.Shared.Next(1, 101);
                bool sumaCorrecte = false;
                bool restaCorrecte = false;
                bool producteCorrecte = false;
                bool divisioCorrecte = false;

                Console.WriteLine($"Els nombres que han sortit són {num1} i {num2}.");

                
                Console.WriteLine("Ara digues el resultat de la suma d'aquests.");
                int resultatSumaUsuari = int.Parse(Console.ReadLine());
                int resultatSumaReal = num1 + num2;
                if (resultatSumaUsuari == resultatSumaReal)
                {
                    Console.WriteLine("El resultat és correcte");
                    sumaCorrecte = true;
                }
                else
                {
                    Console.WriteLine("T'has equivocat.");
                }

                Console.WriteLine("Ara fes la resta");
                int resultatRestaUsuari = int.Parse(Console.ReadLine());
                int resultatRestaReal = num1 - num2;
                if (resultatRestaUsuari == resultatRestaReal)
                {
                    Console.WriteLine("El resultat és correcte");
                    restaCorrecte = true;
                }
                else
                {
                    Console.WriteLine("T'has equivocat.");
                }

                Console.WriteLine("Ara calcula el producte");
                int resultatProducteUsuari = int.Parse(Console.ReadLine());
                int resultatProducteReal = num1 * num2;
                if (resultatProducteUsuari == resultatProducteReal)
                {
                    Console.WriteLine("El resultat és correcte");
                    producteCorrecte = true;
                }
                else
                {
                    Console.WriteLine("T'has equivocat.");
                }

                Console.WriteLine("Ara calcula la divisió entera");
                int resultatDivisioUsuari = int.Parse(Console.ReadLine());
                int resultatDivisioReal = num1 / num2;
                if (resultatDivisioUsuari == resultatDivisioReal)
                {
                    Console.WriteLine("El resultat és correcte");
                    divisioCorrecte = true;
                }
                else
                {
                    Console.WriteLine("T'has equivocat.");
                }

                iteracions++;

                if (sumaCorrecte && restaCorrecte && producteCorrecte && divisioCorrecte)
                {
                    esCorrecte = true;
                }
                else
                {
                    Console.WriteLine("Has de repetir tot el procés!");
                }
            }

            Console.WriteLine($"Has necessitat {iteracions} iteracions per encertar les 4 operacions.");
        }

    }
}
