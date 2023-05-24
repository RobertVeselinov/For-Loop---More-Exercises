using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0;

            double evenSum = 0;

            double evenMaxValue = -1000000000.0;
            double evenMinValue = 1000000000.0;
            double oddMaxValue = -1000000000.0;
            double oddMinValue = 1000000000.0;


            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;
                    if (number > evenMaxValue)
                    {
                        evenMaxValue = number;
                    }
                    if (number < evenMinValue)
                    {
                        evenMinValue = number;
                    }
                }
                else
                {
                    oddSum += number;
                    if (number > oddMaxValue)
                    {
                        oddMaxValue = number;
                    }
                    if (number < oddMinValue)
                    {
                        oddMinValue = number;
                    }
                }
            }
        }
    }
}
