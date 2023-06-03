using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");

        // title, description, date, time, address, speaker, capacity
        Lecture lecture = new Lecture("The Seven Habits of Highly Effective People", "Gianfranco Gosdinski talks about the importance of changing the perception we have about the situations in which we find ourselves in order to take responsibility for our actions. Based on the famous book by Stephen Covey", "07/15/2023", "08:00pm-10:00pm", new Address("Los Fortines 326", "Buenos Aires", "BA"), "Gianfranco Gosdinski", 150);
        lecture.StandardDetails();
        Console.WriteLine();
        lecture.FullDetails();
        Console.WriteLine();
        lecture.ShortDescription();
        Console.WriteLine();

        Reception reception = new Reception("Angie and Marco's Wedding Reception", "Immediately following a wedding ceremony, a reception will be held for Marcos and Angie", "08/20/2025", "4pm-8pm", new Address("Corrientes 4589", "Munro, Buenos Aires", "BA"), "reservations@rsvp.com");
        reception.StandardDetails();
        Console.WriteLine();
        reception.FullDetails();
        Console.WriteLine();
        reception.ShortDescription();
        Console.WriteLine();

        OutdoorGathering outdoorGathering = new OutdoorGathering("Blues Recital", "A small recital will be held on an outdoor stage for our community", "09/12/2023", "10am-12am", new Address("Los Algarrobos 544.", "Lima, Peru", "LIM"), "Sunny Day, 77º f");
        outdoorGathering.StandardDetails();
        Console.WriteLine();
        outdoorGathering.FullDetails();
        Console.WriteLine();
        outdoorGathering.ShortDescription();
        Console.WriteLine();
    }
}