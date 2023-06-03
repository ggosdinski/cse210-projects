public class OutdoorGathering : Event {
    private string _weatherForecast;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast) : base(title, description, date, time, address) {
        _weatherForecast = weatherForecast;
    }
    public void FullDetails() {
        StandardDetails();
        Console.WriteLine($"Weather Forecast: {_weatherForecast}");
    }
    public void ShortDescription() {
        Console.WriteLine($"Event Type: Outdoor gathering");
        ShortDetails();
    }
}
