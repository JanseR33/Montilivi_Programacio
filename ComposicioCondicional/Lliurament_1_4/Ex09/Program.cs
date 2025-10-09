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

            string qualitat = NotaQualitativa(notaExamen, notaPractiques);
            Console.WriteLine($"La nota qualitativa és: {qualitat}");
        }

        public static string NotaQualitativa(double notaExamen, double notaPractiques)
        {
            const double PERCENTATGE_EXAMEN = 0.8;
            const double PERCENTATGE_PRACTIQUES = 0.2;

            if (notaExamen < 3 || notaPractiques < 3)
            {
                return "Suspens";
            }

            double notaFinalAssignatura =
                (notaExamen * PERCENTATGE_EXAMEN) + (notaPractiques * PERCENTATGE_PRACTIQUES);

            const double EPS = 1e-9;
            if (Math.Abs(notaFinalAssignatura - 10.0) < EPS)
                return "Matrícula d’honor";

            if (notaFinalAssignatura < 5)
                return "Suspens";
            if (notaFinalAssignatura < 7)
                return "Aprovat";
            if (notaFinalAssignatura < 9)
                return "Notable";

            return "Excel·lent";
        }
    }
}
