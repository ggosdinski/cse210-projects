public class Bike : Activity 
{
    private double _speed;
    public Bike(string date, double minutes, double speed) : base(date, minutes) {
        _speed = speed;
    }
    public override double GetDistance() {
        return _minutes / GetPace();
    }
    public override double GetSpeed() {
        return _speed;
    }
    public override double GetPace() {
        return 60 / _speed;
    }
    public override string GetActivity(){
        return "Biking";
    }
}