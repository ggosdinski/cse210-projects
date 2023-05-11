using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment homework = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(homework.GetSummary()) ;

        MathAssignment homework2 = new MathAssignment("7.3", "8-19", "Roberto Rodriguez", "Fractions");
        Console.WriteLine(homework2.GetSummary()) ;
        Console.WriteLine(homework2.GetHomeworkList()) ;

        WritingAssignment homework3 = new WritingAssignment("The Causes of World War II", "Mary Waters","European History");
        Console.WriteLine(homework3.GetSummary()) ;
        Console.WriteLine(homework3.GetWritingInformation()) ;
    }
}