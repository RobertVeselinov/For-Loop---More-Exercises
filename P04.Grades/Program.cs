using System;

namespace P04.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double grade = 0;
            double averageGrade = 0;
            double weak = 0;
            double middle = 0;
            double good = 0;
            double excellent = 0;

            for (int i = 1; i <= n; i++)
            {
                grade = double.Parse(Console.ReadLine());
                averageGrade += grade;

                if (grade >= 2.00 && grade <= 2.99)
                {
                    weak++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    middle++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    good++;
                }
                else if (grade >= 5.00)
                {
                    excellent++;
                }
            }

            Console.WriteLine($"Top students: {excellent / n * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {good / n * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {middle / n * 100:f2}%");
            Console.WriteLine($"Fail: {weak / n * 100:f2}%");
            Console.WriteLine($"Average: {averageGrade / n:f2}");
        }
    }
}
