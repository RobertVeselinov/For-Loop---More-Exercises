using System;
using System.Security.Cryptography;

namespace P11.OddEvenPosition
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

            bool fails = false;
            bool fails1 = false;
            double number1 = 0;



            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                number1 = number;
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
            string evenMax = evenMaxValue.ToString();
            string evenMin = evenMinValue.ToString();
            string oddMax = oddMaxValue.ToString();
            string oddMin = oddMinValue.ToString();



            if (evenMaxValue == 0 || evenMaxValue == -1000000000.0 )
            {
                fails= true;
            }
            if (oddMaxValue ==0 || oddMaxValue == -1000000000.0)
            {
                fails1= true;
            }

            if (number1 == 0)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else if (fails)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMinValue:f2},");
                Console.WriteLine($"OddMax={oddMaxValue:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else if (fails1)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={evenMinValue:f2},");
                Console.WriteLine($"EvenMax={evenMaxValue:f2}");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMinValue:f2},");
                Console.WriteLine($"OddMax={oddMaxValue:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={evenMinValue:f2},");
                Console.WriteLine($"EvenMax={evenMaxValue:f2}");
            }
        }
    }
}
