using System;

namespace PreWorkCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrayMaxResult();
            //leapYearCalender();
            perfectSequence();

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

        
        private static void leapYearCalender()
        {
            bool cont = true;
            while (cont)
            {
                Console.Write("Enter a year to see if it is a leap year: ");
                int year = int.Parse(Console.ReadLine());
                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine("This is a leap year!");
                }
                else
                {
                    Console.WriteLine("Sorry, This is not a leap year!");
                }
            }

        }

        private static void perfectSequence()
        {

            bool cont = true;

            while (cont)
            {


                Console.Write("Please write a series of numbers using a comma lets see if it is a perfect sequence!: ");
                string userInput = Console.ReadLine();

                while (!userInput.Contains(","))
                {
                    Console.WriteLine("Please try again using a comma!");
                    userInput = Console.ReadLine();
                }

                string[] splitString = userInput.Split(",");
                int[] numArr = Array.ConvertAll(splitString, item => int.Parse(item));

                int sum = 0;
                int product = 1;

                foreach (var item in numArr)
                {
                    if (item < 0)
                    {
                        Console.WriteLine("You entered a negative number, this is not a perfect sequence");
                    }
                    else
                    {
                        sum += item;
                        product *= item;
                    }
                }

                if (sum == product)
                {
                    Console.WriteLine("Yes, do have a perfect sequence! Congrats");
                }
                else
                {
                    Console.WriteLine("No, sorry this is not a perfect sequence");
                }
            }



            Console.ReadLine();
        }


    }
}