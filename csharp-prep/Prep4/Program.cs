using System;
//using System.Collections.Generic;
using System.Linq;
// Lo uso para poder usar la funcion Average()


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        while(number != 0)
        {
            Console.WriteLine("Please, enter a number. Digit 0 to finish.");
            number = int.Parse(Console.ReadLine());
        
            if (number != 0)
                {
                    numbers.Add(number); 
                }
            
        }
        // Getting the sum of all elements
        int sum = 0;
        foreach (int numb in numbers)
        {
            sum = sum + numb;
        }
        Console.WriteLine($"The sum is {sum}");

        // Getting the average
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}"); 
        /*    float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {avg}"); */

        // Getting the maximun value
        Console.WriteLine($"The maximum element is: {numbers.Max()}");
    }   
}