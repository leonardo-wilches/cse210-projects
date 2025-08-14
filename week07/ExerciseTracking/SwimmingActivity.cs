public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetActivityName()
    {
        return "Swimming";
    }
}