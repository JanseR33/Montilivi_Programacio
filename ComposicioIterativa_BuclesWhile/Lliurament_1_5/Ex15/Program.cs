namespace Ex15
{
    internal class Program
    {
        /// <summary>
        /// Aquest programa mira els partits de fútbol d'un arxiu i et diu els resultats del partit
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            StreamReader partitsLliga = new StreamReader("Girona lliga23_24_v2.txt");

            int golRival = 0, golGir = 0;
            int puntuacioTotal = 0;
            int partitsGuanyants = 0, partitsPerduts = 0, partitsEmpat = 0;
            string linea;

            linea = partitsLliga.ReadLine();
            Console.WriteLine(linea);

            if (linea != null)
            {
                golRival = int.Parse(linea);
                linea = partitsLliga.ReadLine();
            }

            while (linea != null)
            {
                if (linea != null)
                {
                    golGir = int.Parse(linea);

                    if (golGir > golRival)
                    {
                        partitsGuanyants++;
                        puntuacioTotal += 3;
                    }
                    else if (golGir < golRival) partitsPerduts++;
                    else
                    {
                        partitsEmpat++;
                        puntuacioTotal += 1;
                    }

                    linea = partitsLliga.ReadLine();
                }

                if (linea != null)
                {
                    golRival = int.Parse(linea);
                    linea = partitsLliga.ReadLine();
                }
            }

            Console.WriteLine($"el total de partits que han guanyat el Girona es de: {partitsGuanyants}");
            Console.WriteLine($"el total de partits que hna perdut el Girona es de: {partitsPerduts}");
            Console.WriteLine($"el total de partits que han enpatat el Girona es de es de: {partitsEmpat}");
            Console.WriteLine($"el total de punts fets del Girona es de {puntuacioTotal}");
        }
    }
}