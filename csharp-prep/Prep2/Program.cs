using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter your grade percentage: ");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);

        string letter = "A";

        if(gradeInt >= 90)
        {
           letter = "A";
        }

        else if(gradeInt >= 80)
        {
             letter = "B";
        }

        else if(gradeInt >= 70)
        {
             letter = "C";
        }

        else if(gradeInt >= 60)
        {
            letter = "D";
        }

        else
        {
             letter = "F";
        }

        Console.WriteLine($"Your grade s {letter}");

        if(gradeInt >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }

        else
        {
            Console.WriteLine("You did not passed the course. Try again!.");
        }
    }
}