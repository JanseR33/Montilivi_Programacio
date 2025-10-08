namespace Ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///Lletra majúscula aleatoria entre la A i la Z
            /// </summary>
            int lletraMaj = Random.Shared.Next('A', 'Z' + 1);
            Console.WriteLine($"{(char)lletraMaj}");
        }
    }
}
