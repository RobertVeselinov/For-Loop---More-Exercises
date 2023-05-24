using System;

namespace P01.BackToThePast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            double spendMoney = 0;
            int ivanYears = 18;
            for (int i = 1800; i <= year; i++)

            {
                if (i % 2 == 0)
                {
                    spendMoney += 12000;
                }
                else
                {
                    spendMoney += 12000 + 50 * ivanYears;
                }
                ivanYears++;
            }
            if (money >= spendMoney)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money - spendMoney:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(spendMoney - money):f2} dollars to survive.");
            }
        }
    }
}
