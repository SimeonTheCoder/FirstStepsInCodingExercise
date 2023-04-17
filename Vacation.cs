using System;

namespace SoftUni
{
    class DepositCalculator
    {
        static void Main(string[] args) {
            int numberOfPages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double pagesPerDay = numberOfPages / days;
            double hoursPerDay = pagesPerDay / pagesPerHour;

            Console.WriteLine(hoursPerDay);
        }
    }
}