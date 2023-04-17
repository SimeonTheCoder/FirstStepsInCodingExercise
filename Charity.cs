using System;

namespace SoftUni
{
    class Charity
    {
        static double cakePrice = 45.0;
        static double goffPrice = 5.80;
        static double pancakePrice = 3.20;

        static void Main(string[] args) {
            int days = int.Parse(Console.ReadLine());

            int people = int.Parse(Console.ReadLine());

            int cakesCount = int.Parse(Console.ReadLine());
            int goffCount = int.Parse(Console.ReadLine());
            int pancakesCount = int.Parse(Console.ReadLine());

            double finalPrice = 0.0;

            finalPrice += cakesCount * cakePrice;
            finalPrice += goffCount * goffPrice;
            finalPrice += pancakesCount * pancakePrice;

            finalPrice *= people;
            finalPrice *= days;

            finalPrice -= finalPrice / 8.0;

            Console.WriteLine(finalPrice);
        }
    }
}