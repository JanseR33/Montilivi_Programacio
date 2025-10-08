using System.Text;

namespace Ex07
{
    internal class Program
    {

        /// <summary>
        /// Aquest programa calcula a la velocitat a la que va un vehicle i determina la multa adient
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("A quina velocitat anava el vehicle multat?");
            int velocitat = int.Parse(Console.ReadLine());
            string multa = Multa(velocitat);
            Console.WriteLine(multa);
        }

        /// <summary>
        /// Aquesta funció calcula i determina quina multa ha de rebre depenent de la velocitat
        /// </summary>
        /// <param name="velocitat">Velocitat introduïda per l'usuari</param>
        /// <returns></returns>
        public static string Multa (int velocitat)
        {
            string multa;

            if (velocitat == 0)
            {
                multa = "el vehicle ha d'estar en moviment";
            }
            else if (velocitat < 80)
            {
                multa = "No ha estat multat";
            }
            else if (velocitat >= 80 && velocitat <= 99)
            {
                multa = "La multa és de 100€";
            }
            else if (velocitat >= 100 && velocitat <= 129)
            {
                multa = "La multa és de 300€";
            }
            else
            {
                multa = "La multa és de 600€ + la retirada del carnet de conduir.";
            }
                return multa;
        }
    }
}
