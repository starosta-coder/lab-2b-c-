using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Laba4_13var
{
    class Triangle
    {
        private double a, b, c;
        private double P;
        private double S;

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            if (isTriangle())
            {
                P = a + b + c;
                S = Math.Sqrt(P * (P - a) * (P - c) * (P - b));
            }
            else System.Windows.Forms.MessageBox.Show("триугольник не правильный , нужны другие значения");
        }

        public Triangle()
        {
        }

        public bool isTriangle()
        {
            if (((a + b > c) && (b + c > a) && (c + a > b)))
                return true;
            return false;
        }
        public void ShowInfo()
        {
            Console.WriteLine("1 сторона {0}", a);
            Console.WriteLine("2 сторона {0}", b);
            Console.WriteLine("3 сторона {0}", c);

        }
        public double getPerimetr()
        {
            return P;
        }
        public double getSquare()
        {
            return S;
        }
        public void Degree()
        {
            double A = Math.Acos(Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c);
            double B = Math.Acos(Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c);
            double C = Math.Acos(Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2)) / (2 * b * a);
            Console.WriteLine("Угол B {0}", B);
            Console.WriteLine("Угол C {0}", C);
            Console.WriteLine("Угол А {0}", A);
        }
        public override string ToString()
        {
            return string.Format($"Триугольник со сторонами : {a}-{b}-{c}\t" +
                $"\nПериметр - {P}\t\t\t" +
                $"\nПлощадь - {S}");
        }
        public string BineryWrite()
        {
            return string.Format($"{a} {b} {c}");
        }

    }
}