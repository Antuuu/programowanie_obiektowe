using System;
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
    [TestMethod]  
    public void Test_FractionFloor()
    {
        Fraction fraction = new Fraction(licznik,mianownik);  
        Assert.AreEqual(0, fraction.Zaokraglijwdol());
    }
    [TestMethod]  
    public void Test_Product()
    {
        Fraction fraction = new Fraction(licznik,mianownik);
        Fraction fraction2 = new Fraction(mianownik,licznik);
        Assert.AreEqual("24/24", (fraction * fraction2).ToString());
    }
    [TestMethod]  
    public void Test_Quotient()
    {
        Fraction fraction = new Fraction(licznik,mianownik);
        Fraction fraction2 = new Fraction(mianownik,licznik);
        Assert.AreEqual("16/36", (fraction / fraction2).ToString());
    }   
    [TestMethod]  
    public void Test_Sum()
    {
        Fraction fraction = new Fraction(licznik,mianownik);
        Fraction fraction2 = new Fraction(mianownik,licznik);
        Assert.AreEqual("52/24", (fraction + fraction2).ToString());
    }
    [TestMethod]  
    public void Test_Difference()
    {
        Fraction fraction = new Fraction(licznik,mianownik);
        Fraction fraction2 = new Fraction(mianownik,licznik);
        Assert.AreEqual("-20/24", (fraction - fraction2).ToString());
    }  
    [TestMethod]  
    public void Test_Equals()
    {
        Fraction fraction = new Fraction(licznik,mianownik);
        Fraction fraction2 = new Fraction(mianownik,licznik);
        Assert.AreEqual(false, fraction.Equals(fraction2));
    }  
    [TestMethod]  
    public void Test_Comparable()
    {
            Fraction[] a =
            {
                new Fraction(1,10),
                new Fraction(5,10),
                new Fraction(6,20),
                new Fraction(10,8),
                new Fraction(34,7)
                
            };
        Array.Sort(a);
        Assert.AreEqual("1/10",a[0].ToString());
    }  
    
}
