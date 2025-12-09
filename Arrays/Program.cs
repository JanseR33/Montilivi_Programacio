using System.Diagnostics.SymbolStore;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.Marshalling;

namespace Arrays
{

    public class MetodesArrays
    {
        public static void Main()
        { }
        // --- VECTORS ---
        public static int[] OmpleNaturals(int n)
        {
            int[] naturals = new int[n];

            for (int cont = 0; cont < n; cont++)
            {
                naturals[cont] = cont + 1;
            }

            return naturals;
        }

        public static int[] GeneraTaula(int n, int llavor = 0)
        {
            Random rnd = new Random(llavor);
            int[] numAleatori = new int[n];

            for (int cont = 0; cont < n; cont++)
            {
                numAleatori[cont] = rnd.Next(-100, 101);
            }

            return numAleatori;
        }
        public static int SumaTaula(int[] taula)
        {
            int sum = 0;

            for (int cont = 0; cont < taula.Length; cont++)
            {
                sum += taula[cont];
            }

            return sum;
        }
        public static int MinimTaula(int[] taula)
        {
            int min = taula[0];

            for (int cont = 1; cont < taula.Length; cont++)
            {
                int valAct = taula[cont];
                if (min > valAct)
                {
                    min = valAct;
                }
            }
            return min;
        }
        public static int PosicioMinimTaula(int[] taula)
        {
            int min = taula[0];
            int posicio = 0;

            for (int cont = 1; cont < taula.Length; cont++)
            {
                int valAct = taula[cont];
                if (min > valAct)
                {
                    min = valAct;
                    posicio = cont;
                }
            }

            return posicio;
        }
        public static int MaximTaula(int[] taula)
        {
            int max = taula[0];

            for (int cont = 1; cont < taula.Length; cont++)
            {
                int valAct = taula[cont];
                if (max < valAct)
                {
                    max = valAct;
                }
            }
            return max;
        }
        public static double MitjanaTaula(int[] taula)
        {
            int sum = 0;
            double mitjana;
            for (int cont = 0; cont < taula.Length; cont++)
            {
                sum += taula[cont];
            }
            mitjana = Math.Round((double)sum / taula.Length, 2);
            return mitjana;
        }
        public static int[] CapgiraTaula(int[] taula)
        {
            for (int index = 0, temp; index < taula.Length / 2; index++)
            {
                temp = taula[index];
                taula[index] = taula[taula.Length - 1 - index];
                taula[taula.Length - 1 - index] = temp;
            }

            return taula;
        }
        public static int PosicioDe(int[] t, int valor)
        {
            int index = 0;
            int resposta;
            while (index < t.Length && t[index] != valor)
            {
                index++;
            }
            if (index == t.Length)
            {
                resposta = -1;
            }
            else
            {
                resposta = index;
            }

            return resposta;
        }
        public static bool Conte(int[] t, int valor)
        {
            return PosicioDe(t, valor) != -1;
        }
        public static bool ConteEnRang(int[] t, int valor, int indexDesDe, int indexFinsA)
        {
            int index = indexDesDe;
            
            while(index < indexFinsA && t[index] != valor)
            {
                index++;
            }
            
            return index < indexFinsA;
        }

        public static string TaulaAString(int[] taula)
        {
            string valor = "";

            for (int index = 0; index < taula.Length; index++)
            {
                valor += ($"Index {index}: {taula[index]}");
                if (index < taula.Length - 1) valor += "\n";
            }
            return valor;
        }
        public static int[] ComunsOrdenades(int[] t1, int[] t2) => throw new NotImplementedException();
        public static int[] FusioOrdenades(int[] t1, int[] t2) => throw new NotImplementedException();

        // --- MATRIUS ---
        public static int[,] OmpleMatriuPerFiles(int fila, int columna) => throw new NotImplementedException();
        public static int[,] OmpleMatriuPerColumnes(int fila, int columna) => throw new NotImplementedException();
        public static int[,] OmpleMatriuConsecutius(int fila, int columna) => throw new NotImplementedException();
        public static int[,] OmpleMatriuConsecutiusInvers(int fila, int columna) => throw new NotImplementedException();
        public static int[,] OmpleMatriuIdentitat(int nFiles) => throw new NotImplementedException();
        public static int MinimMatriu(int[,] matriu) => throw new NotImplementedException();
        public static int[] PosicioMinimMatriu(int[,] matriu) => throw new NotImplementedException();
    }
}
