using System;

namespace SoftUni
{
    class DepositCalculator
    {
        static void Main(string[] args) {
            double depositSum = double.Parse(Console.ReadLine());
            double depositDue = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double increase = percent * depositSum / 100.0;

            depositSum += increase / 12.0 * depositDue;

            Console.WriteLine(depositSum);
        }
    }
}