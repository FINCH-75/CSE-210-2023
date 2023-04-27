using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int Number = randomGenerator.Next(1, 100);

        int guess = -1;

        while (guess != Number)
        {

            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (guess < Number)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > Number)
            {
                Console.WriteLine("lower");

            }

            else
            {
                Console.WriteLine("Correct!");
            }






        }


        



    }
}