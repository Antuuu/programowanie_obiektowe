using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Fraction(1, 3);
            var test2 = new Fraction(1, 3);
            Console.WriteLine(test.Details());
            Console.WriteLine(test.Equals(test2));
        }
    }
    public class Fraction : IEquatable<Fraction>
    {
        public bool Equals(Fraction Fraction)
        {
            return (this.licznik/this.mianownik) ==
                   (Fraction.licznik/Fraction.mianownik);
        }



        private float licznik, mianownik;
        public Fraction()
        {
        }
        public Fraction(int a, int b)
        {
            licznik = a;
            mianownik = b;
        }
        public Fraction(Fraction previousFraction)
        {
            licznik = previousFraction.licznik;
            mianownik = previousFraction.mianownik;
        }
        public string Details()
        {
            return " Fraction to: " + (licznik/mianownik).ToString();
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a + b);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a - b);
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a * b);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction(a / b);
        }


    }




}