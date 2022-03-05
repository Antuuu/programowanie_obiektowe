using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Ułamek(1, 3);
            var test2 = new Ułamek(7, 6);
            Console.WriteLine(test.Details());
            Console.WriteLine(test.Equals(test2));
            Console.WriteLine(test.Equals(test2));
        }
    }
    public class Ułamek : IEquatable<Ułamek>, IComparable<Ułamek>
    {
        public bool Equals(Ułamek ułamek)
        {
            return (this.licznik/this.mianownik) ==
                (ułamek.licznik/ułamek.mianownik);
        }

        public int CompareTo(Ułamek other)
        {
            // If other is not a valid object reference, this instance is greater

        }

        private float licznik, mianownik;
        public Ułamek()
        {
        }
        public Ułamek(int a, int b)
        {
            licznik = a;
            mianownik = b;
        }
        public Ułamek(Ułamek previousUłamek)
        {
            licznik = previousUłamek.licznik;
            mianownik = previousUłamek.mianownik;
        }
        public string Details()
        {
            return " Ułamek to: " + (licznik/mianownik).ToString();
        }
        public static Ułamek operator +(Ułamek a, Ułamek b)
        {
            return new Ułamek(a + b);
        }
        public static Ułamek operator -(Ułamek a, Ułamek b)
        {
            return new Ułamek(a - b);
        }
        public static Ułamek operator *(Ułamek a, Ułamek b)
        {
            return new Ułamek(a * b);
        }
        public static Ułamek operator /(Ułamek a, Ułamek b)
        {
            return new Ułamek(a / b);
        }


    }




}
