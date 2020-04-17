using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSecondlab_2b_
{
    class Triangls
    {
        BookT[] triangls;
        int LastTriangleNumber;
        public struct BookT
        {
            public int num;
            public double s;
            public bool isOrt;

            public BookT(int num, double s, bool isOrt)
            {
                this.num = num;
                this.s = s;
                this.isOrt = isOrt;
            }

            public string BookToString()
            {
                string result = "";

                result = this.num + " (" + this.s +  ");";

                return result;
            }

            public double getS()
            {
                return this.s;
            }

            public bool IsOrt()
            {
                return this.isOrt;
            }
        }
        public Triangls()
        {
            triangls = new BookT[0];
            LastTriangleNumber = -1;
        }

        public Triangls(int N)
        {
            triangls = new BookT[N];
            LastTriangleNumber = -1;
        }

        public bool addTriangle(int num, double s, bool isOrt)
        {
            if (LastTriangleNumber + 1< triangls.Length)
            {
                triangls[++LastTriangleNumber] = new BookT(num, s, isOrt);
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < triangls.Length; i++)
            {
                result += triangls[i].BookToString() + Environment.NewLine;
            }

            return result;
        }
        public string ReturnResult()
        {
            string result = "";
            double min = 0, max = 0;
            bool minones = true;

            for (int i = 0; i < triangls.Length; i++)
            {
                if (minones)
                {
                    min = triangls[i].getS();
                    max = triangls[i].getS();
                    minones = false;
                }
                double newmin = triangls[i].getS();
                double newmax = triangls[i].getS();
                if (newmin < min)
                    min = newmin;
                if (newmax > max)
                    max = newmax; 
            }

            int numMin = 0, numMax = 0;

            for (int i = 0; i < triangls.Length; i++)
            {
                if (min == triangls[i].getS())
                    numMin = i + 1;
                if (max == triangls[i].getS())
                    numMax = i + 1;
            }

            int numFirst = 0, numSecond = 0;
            string sameT = "";

            for (int i = 0; i < triangls.Length; i++)
            {
                for (int t = 0; t < triangls.Length; t++)
                {
                    if (triangls[i].IsOrt() && triangls[t].IsOrt())
                    {
                        if (triangls[i].getS() == triangls[t].getS() && i != t)
                        {
                            numFirst = t + 1;
                            numSecond = i + 1;
                            sameT = "Номера одинаковых прямоугольных треугольнтков :" + numFirst + "," + numSecond + ".";
                            break;
                        }
                        else 
                        {
                            sameT = "Нету одиноковых прямоугольных треугольнтков.";
                        }
                    }
                }
            }

            return result = "Минимальная площадь (" +  min + "). У треугольника №" + numMin + ";" + Environment.NewLine
                                + "Максимальная площадь (" + max +") .У треугольника №" + numMax + ";" + Environment.NewLine
                                    + sameT + Environment.NewLine;
        }
    }
}
