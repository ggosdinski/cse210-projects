using System;

class Program
{
    static void Main(string[] args)
    {
        int opt = 0;

        while (opt != 4)
        {
            opt = Menu();
            PickUpActivities(opt);

        }
    }

    static int Menu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Start breathing activity");
        Console.WriteLine("   2. Start reflecting activity");
        Console.WriteLine("   3. Start listing activity");
        Console.WriteLine("   4. Quit");
        Console.WriteLine("Please. enter a number from the menu: ");

        return int.TryParse(Console.ReadLine(), out int i) ? i : 4;
    }

    static void PickUpActivities(int option)
    {
        switch (option)
        {
            case 1:
                {
                    BreathingActivity Act1 = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

                    Act1.DisplayStartingMessage();
                    Act1.BreathingExercise();
                    Act1.DisplayClosingMessage();
                    break;
                }
            case 2:
                {
                    ReflectionActivity Act2 = new ReflectionActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                    Act2.DisplayStartingMessage();
                    Act2.ReflectionExercise();
                    Act2.DisplayClosingMessage();
                    break;
                }
            case 3:
                {
                    ListingActivity Act3 = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

                    Act3.DisplayStartingMessage();
                    Act3.ListingExercise();
                    Act3.DisplayClosingMessage();
                    break;
                }
            default:
                {
                    Console.WriteLine("See you next time!");
                    break;
                }
        }
    }
}