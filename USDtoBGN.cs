using System;

namespace SoftUni
{
    class USDtoBGN
    {
        static void Main(string[] args) {
            double bgn = double.Parse(Console.ReadLine());

            double course = 1.79549;
            double usd = bgn * course;

            Console.WriteLine(usd);
        }
    }
}