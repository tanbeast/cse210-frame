abstract class Activity{
    private DateTime date;
    private double durationInMinutes;

    public Activity(DateTime date, double durationInMinutes){
        this.date = date;
        this.durationInMinutes = durationInMinutes;
    }

    public DateTime GetDate() => date;
    public double GetDurationInMinutes() => durationInMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary(){
        return $"{GetDate().ToString("dd MMM yyyy")} {this.GetType().Name} ({GetDurationInMinutes()} min): " +
               $"Distance {GetDistance():F2} {GetDistanceUnit()}, " +
               $"Speed: {GetSpeed():F2} {GetSpeedUnit()}, " +
               $"Pace: {GetPace():F2} min per {GetDistanceUnit()}";
    }

    protected abstract string GetDistanceUnit();
    protected abstract string GetSpeedUnit();
}
