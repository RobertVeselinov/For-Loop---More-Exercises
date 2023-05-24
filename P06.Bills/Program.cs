using System;

namespace P06.Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            double electricityPrice;
            double electricityPrice1 = 0;
            double waterPrice = 0;
            double internetPrice = 0;
            double otherPriceAll = 0;


            for (int i = 1; i <= month; i++)
            {
                electricityPrice = double.Parse(Console.ReadLine());
                electricityPrice1 += electricityPrice;

                waterPrice += 20;
                internetPrice += 15;
                double otherPricePerMonth = electricityPrice + 20 + 15;
                otherPricePerMonth += otherPricePerMonth * 0.2;
                otherPriceAll += otherPricePerMonth;
                 
            }
            double sumAll = electricityPrice1 + waterPrice + internetPrice + otherPriceAll; 

            Console.WriteLine($"Electricity: {electricityPrice1:f2} lv");
            Console.WriteLine($"Water: {waterPrice:f2} lv");
            Console.WriteLine($"Internet: {internetPrice:f2} lv");
            Console.WriteLine($"Other: {otherPriceAll:f2} lv");
            Console.WriteLine($"Average: {sumAll / month:f2} lv");
        }
    }
}
