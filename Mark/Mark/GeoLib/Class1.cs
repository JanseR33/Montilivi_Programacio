namespace GeoLib
{
    public class Geo
    {
        public static double Distancia(double x1, double y1, double x2, double y2)
        {
            double distancia;
            distancia = Math.Sqrt(Math.Pow(x1 -x2, 2) + Math.Pow(y1 -y2, 2));
            return distancia;
        }
        public static double PerimetreCercle(double radi)
        {
            double perimetre;
            perimetre = Math.PI * Math.Pow(radi, 2);
            return perimetre;
        }
    }
}
