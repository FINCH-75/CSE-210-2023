using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        
        DisplayWelcomeMessage();
        string userName = UserNamePrompt();
        int userNumber = favNumberPrompt();
        int squaredNumber = SquaredNum(userNumber);
        displayResults(userName,squaredNumber);


/////////////////////////////////////////////////////////////////////////////////////////////////////////

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine($"Welcome to my program!");
        }

////////////////////////////////////////////////////////////////////////////////////////////////////////

        static string UserNamePrompt()
    {
        Console.Write("Please enter your full name.");
        string name = Console.ReadLine();

        return name;
    }
///////////////////////////////////////////////////////////////////////////////////////////////////////////

        static int favNumberPrompt()
        {
            Console.Write($"What is your favorite number?");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
///////////////////////////////////////////////////////////////////////////////////////////////////////////

        static int SquaredNum(int number)
        {
            int square = number * number;

            return square;
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////

        static void displayResults(string name, int square)
        {
            Console.WriteLine($"{name}, your favorite number squared is {square}");
        }





    }
}