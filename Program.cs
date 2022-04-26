using System;

namespace CSharp.LabExercise2
{
    internal class Program
    {
        static void Number1()
        {
            var number = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter number: ");
                int numberValue = Convert.ToInt32(Console.ReadLine());
                int currentNumberIndex = Array.IndexOf(number, numberValue);


                if (numberValue < 10 || numberValue > 100)
                {
                    Console.WriteLine("number must be between 10 and 100");
                    i--;
                }

                else if (currentNumberIndex >= 0)
                {
                    Console.WriteLine("{0} has already been entered", numberValue);
                    i--;
                }
                else
                {
                    number[i] = numberValue;
                    Console.WriteLine($"{number[0]},{number[1]},{number[2]},{number[3]},{number[4]}");
                }             

            }         

        } 


        class Lasagna
        {
            public int ExpectedMinutesInOven()
            {
                return 40;
            }

            public int RemainingMinutesInOven(int Remaining)
            {
                return Remaining;
            }

            public int PreparationTimeInMinutes(int Preparation)
            {
                return Preparation;
            }

            public int ElapsedTimeInMinutes(int LayerPreparationTime, int OvenTime)
            {
                int TotalTime = (LayerPreparationTime * 2) + OvenTime;
                return TotalTime;
            }
        }

        static void Main(string[] args)
        {
            Number1();

            Console.WriteLine("\n\n");

            Lasagna lasagna = new Lasagna();
            Console.WriteLine($"Expected oven time is : {lasagna.ExpectedMinutesInOven()} minutes");
            Console.WriteLine(" ");
            

            Console.Write("Enter current time in oven (in minutes) : ");
            int Remaining = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Remaining time in oven : {lasagna.ExpectedMinutesInOven() - Remaining} minutes");
            Console.WriteLine(" ");

            Console.Write("Enter number of layers : ");
            int Preparation = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Total preparation time : {Preparation * 2} minutes");
            Console.WriteLine(" ");

            Console.Write("Enter number of layers added : ");
            int LayerPreparationTime = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter total time in oven (in minutes) : ");
            int OvenTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            int TotalTime = lasagna.ElapsedTimeInMinutes(LayerPreparationTime, OvenTime);
            Console.Write($"Total elapsed time : {TotalTime} minutes");

            Console.WriteLine("\n");
        }
    }
}
