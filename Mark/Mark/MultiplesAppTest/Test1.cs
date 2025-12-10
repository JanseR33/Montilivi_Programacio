using MultiplesApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace MultiplesAppTest;

[TestClass]
public class MultiplesTest
{
    [TestMethod]
    // Testeja números múltiples de 2 i de 7
    public void Test_Multiples()
    {
        bool resultat1 = Program.EsMultipleDe2(4);
        Assert.IsTrue(resultat1);

        bool resultat2 = Program.EsMultipleDe2(5);
        Assert.IsFalse(resultat2);

        bool resultat3 = Program.EsMultipleDe7(14);
        Assert.IsTrue(resultat3);

        bool resultat4 = Program.EsMultipleDe7(10);
        Assert.IsFalse(resultat4);
    }

    [TestMethod]
    // Testeja si el número entrat és 0
    public void Test_Zero()
    {
        bool resultat1 = Program.EsMultipleDe2(0);
        Assert.IsTrue(resultat1);

        bool resultat2 = Program.EsMultipleDe7(0);
        Assert.IsTrue(resultat2);
    }
    
    [TestMethod]
    [DataRow(-4, true)]
    // Testeja quan el número entrat és negatiu ( ha de funcionar igual )
    public void Test_Negatius()
    {
        bool resultat1 = Program.EsMultipleDe2(-4);
        Assert.IsTrue(resultat1);

        bool resultat2 = Program.EsMultipleDe2(-5);
        Assert.IsFalse(resultat2);

        bool resultat3 = Program.EsMultipleDe7(-14);
        Assert.IsTrue(resultat3);

        bool resultat4 = Program.EsMultipleDe7(-10);
        Assert.IsFalse(resultat4);
    }

    [TestMethod]
    public void Test_FormatInvalid()
    {
        try
        {
            Convert.ToInt32("abc");
            Assert.Fail("Hauria de sortir un FormatException");
        }
        catch (FormatException)
        {
            // Test passa correctament
        }
    }
}