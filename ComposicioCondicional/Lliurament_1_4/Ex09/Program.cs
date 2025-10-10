namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueix la nota de les pràctiques");
            double notaPractiques = double.Parse(Console.ReadLine());
            Console.WriteLine("Introdueix la nota de l'examen");
            double notaExamen = double.Parse(Console.ReadLine());

            string notaFinal = NotaQualitativa(notaExamen, notaPractiques);
            Console.WriteLine($"La nota qualitativa és: {notaFinal}");
        }

        public static string NotaQualitativa(double notaExamen, double notaPractiques)
        {
            const double PERCENTATGE_EXAMEN = 0.8;
            const double PERCENTATGE_PRACTIQUES = 0.2;

            string notaFinal;

            if (notaExamen < 3 || notaPractiques < 3)
            {
                notaFinal = "Suspens";
            }

            double notaFinalNum = (notaExamen * PERCENTATGE_EXAMEN) + (notaPractiques * PERCENTATGE_PRACTIQUES);

            if (notaFinalNum == 10)
            {
                notaFinal = "Matrícula d’honor";
            }

            else if (notaFinalNum < 5 )
                notaFinal = "Suspens";
            else if (notaFinalNum < 7)
                notaFinal = "Aprovat";
            else if (notaFinalNum < 9)
                notaFinal = "Notable";
            else
            {
                notaFinal = "Excel·lent";
            }
                return notaFinal;
        }
    }
}
