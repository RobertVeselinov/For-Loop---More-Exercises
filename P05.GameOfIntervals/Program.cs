using System;

namespace P05.GameOfIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int digitForMoves;

            double result = 0;
            double invalidNumbers = 0;
            double f0to9 = 0;
            double f10to19 = 0;
            double f20to29 = 0;
            double f30to39 = 0;
            double f40to50 = 0;

            for (int i = 1; i <= n; i++)
            {
                digitForMoves = int.Parse(Console.ReadLine());

                if (digitForMoves >=0 && digitForMoves <= 9)
                {
                    result += digitForMoves * 0.2;
                    f0to9++;

                }
                else if (digitForMoves >= 10 && digitForMoves <= 19)
                {
                    result += digitForMoves * 0.3;
                    f10to19++;
                }
                else if (digitForMoves >= 20 && digitForMoves <= 29)
                {
                    result += digitForMoves * 0.4;
                    f20to29++;
                }
                else if (digitForMoves >= 30  && digitForMoves <= 39)
                {
                    result += 50;
                    f30to39++;
                }
                else if (digitForMoves >= 40 && digitForMoves <= 50)
                {
                    result += 100;
                    f40to50++;
                }
                else
                {
                    result = result / 2;
                    invalidNumbers++;
                }
            }
            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {f0to9 / n * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {f10to19 / n * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {f20to29 / n * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {f30to39 / n * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {f40to50 / n * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumbers / n * 100:f2}%");
        }
    }
}
