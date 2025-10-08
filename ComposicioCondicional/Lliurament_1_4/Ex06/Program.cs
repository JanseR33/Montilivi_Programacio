using System.Security.Cryptography.X509Certificates;

namespace Ex06
{
    internal class Program
    {
        /// <summary>
        /// Aquesta aplicació calcula qui ha guanyat entre l'equip local i l'equip visitant
        /// depenent de la quantitat de gols.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Amb aquest programa podràs fer un càlcul de quins equips han guanyat");
            Console.WriteLine("Digues el nom de l'equip local");
            string equipLocal = Console.ReadLine();
            Console.WriteLine("Ara introdueix el número de gols marcats");
            int golsEquipLocal = int.Parse(Console.ReadLine());
            Console.WriteLine("Ara digues el nom de l'equip visitant");
            string equipVisitant = Console.ReadLine();
            Console.WriteLine("Ara introdueix el número de gols marcats");
            int golsEquipVisitant = int.Parse(Console.ReadLine());

            string informeResultat = InformeResultat(equipLocal, golsEquipLocal, equipVisitant, golsEquipVisitant);

            Console.WriteLine($"{informeResultat}");
        }

        /// <summary>
        /// Aquesta funció determina quins equips han guanyat / perdut i escriu la resposta
        /// </summary>
        /// <param name="equipLocal">El nom de l'equip local</param>
        /// <param name="golsEquipLocal">El número de gols marcats per l'equip local</param>
        /// <param name="equipVisitant">El nom de l'equip visitant</param>
        /// <param name="golsEquipVisitant">Gols marcats per l'equip visitant</param>
        /// <returns></returns>
        public static string InformeResultat(string equipLocal, int golsEquipLocal, string equipVisitant, int golsEquipVisitant)
        {
            string informeResultat;

            if (golsEquipLocal < 0 || golsEquipVisitant < 0)
            {
                informeResultat = "El número de gols no pot ser negatiu";
            }
            else if (golsEquipLocal == golsEquipVisitant)
            {
                informeResultat =$"El {equipLocal} ha empatat al {equipVisitant} amb un resultat de {golsEquipLocal} a {golsEquipVisitant}";
            }
            else if (golsEquipLocal > golsEquipVisitant)
            {

                informeResultat = $"El {equipLocal} ha guanyat al {equipVisitant} amb un resultat de {golsEquipLocal} a {golsEquipVisitant}";
            }
            else
            {
                informeResultat = $"El {equipLocal} ha perdut contra el {equipVisitant} amb un resultat de {golsEquipLocal} a {golsEquipVisitant}";
            }

            return informeResultat;
        }
        }
    }

