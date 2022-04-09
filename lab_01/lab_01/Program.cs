using System;

namespace lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Fraction(2, 4);
            var test2 = new Fraction(21, 8);
            Console.WriteLine("First fraction: " + test.Details());
            Console.WriteLine("Second fraction: " + test2.Details());
            Console.WriteLine("Product" + (test * test2).Details());
            Console.WriteLine("Quotient" + (test / test2).Details());
            Console.WriteLine("Sum" + (test + test2).Details());
            Console.WriteLine("Difference" + (test - test2).Details());
            Console.WriteLine(test.Equals(test2));
            Fraction[] a =
            {
                new Fraction(1,10),
                new Fraction(29,6),
                new Fraction(4,5),
                new Fraction(10,8),
                new Fraction(34,7)
            };
            Array.Sort(a);
            Console.WriteLine("Implementing the IComparable Interface in Displaying Fractions : ");
            foreach (Fraction f in a) Console.WriteLine(f + " ");
            Console.WriteLine("Round:" + test2.Zaokraglijdogory());
            Console.WriteLine("Floor:" + test2.Zaokraglijwdol());

        }
    }
    public class Fraction : IEquatable<Fraction>, IComparable
    {
        public bool Equals(Fraction Fraction)
        {
            return (this.licznik * Fraction.mianownik) ==
                   (Fraction.licznik * this.mianownik);
        }

        public int CompareTo(object obj)
        {
            Fraction f = (Fraction)obj;
            if ((float)licznik/mianownik < (float)f.licznik/f.mianownik)
                return -1;
            else if ((float)licznik/mianownik > (float)f.licznik/f.mianownik)
                return 1;
            else return 0;
        }


        private int _licznik;
        private int _mianownik;
        
        public int licznik
        {
             get => _licznik; 
             set => _licznik = value;
         }
        
        public int mianownik
        {
            get => _mianownik; 
            set => _mianownik = value;
        }        
        public Fraction(int a, int b)
        {
            licznik = a;
            mianownik = b;
            if (mianownik == 0)
            {
                throw new ArgumentException("Mianownik nie moze byc zerem.", nameof(mianownik));
            }
        }
        public Fraction(Fraction previousFraction)
        {
            licznik = previousFraction.licznik;
            mianownik = previousFraction.mianownik;
        }
        public string Details()
        {
            return " Fraction is: " + licznik.ToString() + "/" + mianownik.ToString();
        }
        
        public static Fraction operator +(Fraction a) => a;
        public static Fraction operator -(Fraction a) => new Fraction(-a.licznik, a.mianownik);
        public static Fraction operator +(Fraction a, Fraction b)
            => new Fraction(a.licznik * b.mianownik + b.licznik * a.mianownik, a.mianownik * b.mianownik);
        public static Fraction operator -(Fraction a, Fraction b)
            => a + (-b);
        public static Fraction operator *(Fraction a, Fraction b)
            => new Fraction(a.licznik * b.licznik, a.mianownik * b.mianownik);
        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.licznik == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.licznik * b.mianownik, a.mianownik * b.licznik);
        }

        public int Zaokraglijdogory()
        {   
            return (int) Math.Round((float) licznik / mianownik);
        }
        public int Zaokraglijwdol()
        {
            return (int) Math.Floor((float) licznik / mianownik);
        }
        
        public override string ToString()
        {
            return licznik + "/" + mianownik;
        }
    }




}