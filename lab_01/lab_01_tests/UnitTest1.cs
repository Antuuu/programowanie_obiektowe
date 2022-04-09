using lab_01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab_01_tests;

[TestClass]
public class FractionTests
{
    int licznik = 4;
    int mianownik = 6;
    [TestMethod]  
    public void Test_Fraction()
    {

        Fraction fraction = new Fraction(licznik,mianownik);  
        Assert.AreEqual("4/6", fraction.ToString());
    }
    [TestMethod]  
    public void Test_FractionRound()
    {
        Fraction fraction = new Fraction(licznik,mianownik);  
        Assert.AreEqual(1, fraction.Zaokraglijdogory());
    }
}
