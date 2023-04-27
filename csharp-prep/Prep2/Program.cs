using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What grade percentage did you recieve?");
        string percentFromUser = Console.ReadLine() ;
        string letterGrade = "";

        int grade = int.Parse(percentFromUser);

        

        if (grade >= 90)
        {
            letterGrade = "A";
            
        }
        else if (grade >=80)
        {
            letterGrade = "B";
        }
        else if (grade >=70)
        {
            letterGrade = "C";
        }
        else if (grade >=60)
        {
            letterGrade = "D";
        }
        else 
        {
            letterGrade = "F";
        }
        
        Console.WriteLine($"Your letter grade is {letterGrade}");


        if (grade >= 70)
        {
            Console.WriteLine($"Congradulations you have passed!");
        }
        else
        {
            Console.WriteLine($"Sorry you did not pass");
        }
        
        

        
       
    }
}