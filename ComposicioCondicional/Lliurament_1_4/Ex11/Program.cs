namespace Ex11
{
    internal class Program
    {
        /// <summari>
        /// Dissenieu un algorisme que, donat un angle entre -360 i 360 graus, determini en quin quadrant es troba.
        /// </summari>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double angle;
            string quadrant;

            Console.WriteLine("Introduce un angulo entre -360 i 360");
            angle = int.Parse(Console.ReadLine());

            quadrant = Quadrant(angle);

            Console.WriteLine($"{quadrant}");
        }
        /// <summari>
        /// Funcion para determinar el cuadrante correspondiente del numero de angulo introducido
        /// </summari>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static string Quadrant(double angle)
        {
            string quadrant = "";

            if (angle > 0 && angle < 90 || angle < -270 && angle > -360)
            {
                quadrant = ($"L'angle {angle} esta en el quadrant 1");
            }
            else if (angle > 90 && angle < 180 || angle < -180 && angle > -270)
            {
                quadrant = ($"L'angle {angle} esta en el quadrant 2");
            }
            else if (angle > 180 && angle < 270 || angle < -90 && angle > -180)
            {
                quadrant = ($"L'angle {angle} esta en el quadrant 3");
            }
            else if (angle > 270 && angle < 360 || angle < 0 && angle > -90)
            {
                quadrant = ($"L'angle {angle} esta en el quadrant 4");
            }
            else if (angle == 0 || angle == 360 || angle == -360)
            {
                quadrant = ($"L'angle {angle} esta en el quadrant 1 i 4");
            }
            else if (angle == 90 || angle == -270)
            {
                quadrant = ($"L'angle {angle} esta en el quadrant 1 i 2");
            }
            else if (angle == 180 || angle == -180)
            {
                quadrant = ($"L'angle {angle} esta en el quadrant 2 i 3");
            }
            else if (angle == 270 || angle == -90)
            {
                quadrant = ($"L'angle {angle} esta en el quadrant 3 i 4");
            }

            return quadrant;
        }
    }
}
