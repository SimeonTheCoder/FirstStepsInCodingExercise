using System;

namespace SoftUni
{
    class RadToDeg
    {
        static void Main(string[] args) {
            double rad = double.Parse(Console.ReadLine());

            double deg = rad * 180 / Math.PI;
            deg = Math.Round(deg);

            Console.WriteLine(deg);
        }
    }
}