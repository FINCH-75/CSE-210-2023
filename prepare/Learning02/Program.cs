using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello Develop02 World!");
        

        Job job1 = new Job();
        job1._jobTitle = "Power plant Operator 1";
        job1._company = "Tucson Electric Power";
        job1._startYear = 2015;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Power plant Operator 2";
        job2._company = "Tucson Electric Power";
        job2._startYear = 2019;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._firstName = "William";
        myResume._lastName = "Finch";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2); 

        myResume.display(); 




    }
}
   