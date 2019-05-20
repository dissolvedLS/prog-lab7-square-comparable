using System;

namespace prog_lab7_zad3
{
    public interface ICircumcircleIncircle
    {
        double R { get; } // радіус описаного кола
        double r { get; } // радіус вписаного кола
    }
    public interface IMeasurable
    {
        double Perimeter();
        double Area();
    }
    class Square : IMeasurable, ICircumcircleIncircle, IComparable
    {
        public double a;

        public Square()
        {
            a = 0;
        }
        public Square(double a)
        {
            this.a = a;
        }
        public double Perimeter()
        {
            return a * 4;
        }
        public double Area()
        {
            return a * a;
        }

        public double R
        {
            get
            {
                return Math.Sqrt(a * a + a * a) / 2;
            }
        }

        public double r
        {
            get
            {
                return a / 2;
            }
        }

        public int CompareTo(object o)
        {
            Square newSqr = o as Square;
            return this.Perimeter().CompareTo(newSqr.Perimeter());
        }
    }
}
