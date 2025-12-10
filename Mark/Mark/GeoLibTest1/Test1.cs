namespace GeoLibTest
{
    using GeoLib;

    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(1, 2 * Math.PI)]
        [DataRow(2, 4 * Math.PI)]
        public void PerimetreCercleTest(double radi, double expected)
        {
            double actual = Geo.PerimetreCercle(radi);
            Assert.AreEqual(expected, actual, 0.00001);
        }
    }
}