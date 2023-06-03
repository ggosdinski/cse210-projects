public class Run : Activity 
{
    private double _distance;
    public Run(string date, double minutes, double distance) : base(date, minutes) {
        _distance = distance;
    }
    public override double GetDistance() {
        return _distance;
    }
    public override double GetSpeed() {
        return (_minutes / _distance);
    }
    public override double GetPace() {
        return 60 / GetSpeed();
    }
    public override string GetActivity(){
        return "Running";
    }
}