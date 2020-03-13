using System;

namespace PreWorkCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            arrayMaxResult();
            //leapYearCalender();

        }

        private static void arrayMaxResult()
        {

            int[] numArray = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Guess a number from 1-10: ");
                int input = int.Parse(Console.ReadLine());
                while (input > 10)
                {
                    Console.WriteLine("Numbers from 1-10 only please!");
                    input = int.Parse(Console.ReadLine());
                }
                numArray[i] = input;
            }

            Console.WriteLine(string.Join(", ", numArray));
            Console.Write("Pick a number from  list and find out your score: ");

            int picked = 0;
            int chosen = int.Parse(Console.ReadLine());
            int checkNum = Array.IndexOf(numArray, chosen);

            while (checkNum <= -1)
            {
                Console.WriteLine("Please pick a number from the list");
                chosen = int.Parse(Console.ReadLine());
                checkNum = Array.IndexOf(numArray, chosen);
            }

            foreach (var num in numArray)
            {
                if (num == chosen)
                {
                    picked++;
                }
            }
            Console.WriteLine($"Awesome! You picked {chosen} and your score is {chosen * picked}");
            Console.ReadLine();
        }

        /*
        private static void leapYearCalender()
        {

        }
        */
    }
}
