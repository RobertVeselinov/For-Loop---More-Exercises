using System;

namespace P02.Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int doctors = 7;
            int verifiedPatients = 0;
            int unverifiedPatients = 0;


            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && unverifiedPatients > verifiedPatients)
                {
                    doctors++;
                }

                int patients = int.Parse(Console.ReadLine());

                if (patients <= doctors)
                {

                    verifiedPatients += patients;
                }
                else
                {
                    unverifiedPatients += patients - doctors;
                    verifiedPatients += doctors;
                }



            }
            Console.WriteLine($"Treated patients: {verifiedPatients}.");
            Console.WriteLine($"Untreated patients: {unverifiedPatients}.");
        }
    }
}
