using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
       /*  Console.WriteLine($"{ job1._company}"); */
        //job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        /* Console.WriteLine($"{ job2._company}"); */
        //job2.Display();

        Resume Resume = new Resume();
        Resume._name = "Allison Rose";

        Resume._jobs.Add(job1);
        Resume._jobs.Add(job2);

        Resume.Display();
    }

}   