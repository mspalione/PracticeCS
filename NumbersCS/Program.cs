using System;

namespace NumbersCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            //Double-precision
            double aa = 5;
            double bb = 4;
            double cc = 2;
            double dd = (aa + bb) / cc;
            Console.WriteLine(dd);

            double dmax = double.MaxValue;
            double dmin = double.MinValue;
            Console.WriteLine($"The range of double is {dmin} to {dmax}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            //decimal
            decimal decmin = decimal.MinValue;
            decimal decmax = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {decmin} to {decmax}");

            double aaa = 1.0;
            double bbb = 3.0;
            Console.WriteLine(aaa / bbb);

            decimal ccc = 1.0M;
            decimal ddd = 3.0M;
            Console.WriteLine(ccc / ddd);

            //calculate the area of a circle
            double radiusSquared = Math.Pow(2.50, 2);
            var area = radiusSquared * Math.PI;
            Console.WriteLine(area);
        }
    }
}
