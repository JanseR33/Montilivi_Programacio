namespace Ex04
{
    internal class Program
    {
        /// <summary>
        /// Aquest programa demana 2 nombres i escriu els nombres comprimits entre els 2. Aquest es salta els múltiples de 7.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Entra 2 números. El programa mostrarà els números compresos entre aquests. Aquesta versió es salta els múltiples de 7.");
            Console.Write("Número 1: "); 
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Número 2: ");
            int num2 = int.Parse(Console.ReadLine());

            // Sé que no cal i que és innecessari però m'agrada més assegurar-me.
            if (num1 > num2)
            {
                Console.WriteLine("El primer número ha de ser més petit que el segon.");
                return;
            }
            else
            {
                // Això és un separador per que quedi més ordenat.
                Console.WriteLine("---");
                for (num1 = num1, num2 = num2; num1 <= num2; num1++)
                {
                    if (!(num1%7 == 0))
                    {
                        if (num1 <= num2 - 1)
                            Console.WriteLine($"{num1},");
                        else Console.WriteLine($"{num1}.");
                    }

                }
            }
        }
    }
}
