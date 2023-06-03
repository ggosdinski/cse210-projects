public class Event {
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    public Event(string title, string description, string date, string time, Address address) {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public void StandardDetails() {
        Console.WriteLine($"Event Title: {_title}\nDate & Time: {_date} {_time}\nAddress: {_address.GetAddress()} \nDescription: {_description}");
    }
    public void ShortDetails() {
        Console.WriteLine($"Event Title: {_title} \nDate: {_date}");
    }
}