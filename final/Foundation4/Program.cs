using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");
        List<Activity> activities = new List<Activity>();

        DateTime currentTime =  DateTime.Now;
        string currentDate =  currentTime.ToShortDateString();

        activities.Add(new Run(currentDate, 40, 4));
        activities.Add(new Bike(currentDate, 19, 8));
        activities.Add(new Swim(currentDate, 26, 7));

        foreach (Activity activity in activities) {
            activity.GetSummary();
        }
    }
}