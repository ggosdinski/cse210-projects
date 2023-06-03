public class Reception : Event {
    private string _rsvpEmail;
    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address) {
        _rsvpEmail = rsvpEmail;
    }
    public void FullDetails() {
        StandardDetails();
        Console.WriteLine($"Email to RSVP: {_rsvpEmail}");
    }
    public void ShortDescription() {
        Console.WriteLine($"Event Type: Reception");
        ShortDetails();
    }
}