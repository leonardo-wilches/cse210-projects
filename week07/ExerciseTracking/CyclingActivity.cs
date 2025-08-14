public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed / 60) * _length;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
    
    public override string GetActivityName()
    {
        return "Cycling";
    }
}