using System;

namespace SoftUni
{
    class DepositCalculator
    {
        static void Main(string[] args) {
            double price = double.Parse(Console.ReadLine());

            double cakePrice = 0.2 * price;
            double drinksPrice = (1.0 - 0.45) * cakePrice;

            double animatorPrice = price / 3.0;

            double totalBudget = price + cakePrice + drinksPrice + animatorPrice;

            Console.WriteLine(totalBudget);
        }
    }
}