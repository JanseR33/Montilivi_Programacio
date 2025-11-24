namespace Ex06c
{
    internal class Program
    {
        /// <summary>
        /// Un nombre és primer si és divisible només per ell mateix i per 1. El 0 i l’ 1 es consideren no primers per definició.
        /// Escriu un programa per saber si un nombre positiu introduït pel teclat és primer o no.
        /// Donada una seqüència de valors procedents d’un fitxer, informar per a cada valor, si és primer o no (CERCA O RECORREGUT?) Usar el fitxer ALGUNSPRIMERS.TXT
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string NOM_FITXER = "ALGUNSPRIMERS.txt";
            StreamReader lectorFitxer = new StreamReader(NOM_FITXER);

            string? linia;

            while ((linia = lectorFitxer.ReadLine()) != null)
            {
                int liniaNum = int.Parse(linia);
                int divisioActual = 2;
                int cont = 0;

                if (liniaNum <= 1)
                {
                    Console.WriteLine($"{liniaNum} no és primer");
                }
                else
                {
                    while (divisioActual <= liniaNum / 2 && cont == 0)
                    {
                        if (liniaNum % divisioActual == 0)
                        {
                            cont = 1;
                        }
                        divisioActual++;
                    }

                    if (cont == 0)
                    {
                        Console.WriteLine($"{liniaNum} és primer");
                    }
                    else
                    {
                        Console.WriteLine($"{liniaNum} no és primer");
                    }
                }
            }
            lectorFitxer.Close();
        }
    }
}

