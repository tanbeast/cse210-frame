using System;
using System.Collections.Generic;

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

class Running : Activity{
    private double distanceInMiles;

    public Running(DateTime date, double durationInMinutes, double distanceInMiles)
        : base(date, durationInMinutes){
        this.distanceInMiles = distanceInMiles;
    }

    public override double GetDistance() => distanceInMiles;

    public override double GetSpeed() => (distanceInMiles / GetDurationInMinutes()) * 60;

    public override double GetPace() => GetDurationInMinutes() / distanceInMiles;

    protected override string GetDistanceUnit() => "miles";
    protected override string GetSpeedUnit() => "mph";
}

class Cycling : Activity{
    private double speedInMilesPerHour;

    public Cycling(DateTime date, double durationInMinutes, double speedInMilesPerHour)
        : base(date, durationInMinutes){
        this.speedInMilesPerHour = speedInMilesPerHour;
    }

    public override double GetDistance() => (speedInMilesPerHour / 60) * GetDurationInMinutes();

    public override double GetSpeed() => speedInMilesPerHour;

    public override double GetPace() => 60 / speedInMilesPerHour;

    protected override string GetDistanceUnit() => "miles";
    protected override string GetSpeedUnit() => "mph";
}

class Swimming : Activity{
    private int laps;

    public Swimming(DateTime date, double durationInMinutes, int laps)
        : base(date, durationInMinutes){
        this.laps = laps;
    }

    public override double GetDistance() => laps * 50 / 1000 * 0.62;

    public override double GetSpeed() => (GetDistance() / GetDurationInMinutes()) * 60;

    public override double GetPace() => GetDurationInMinutes() / GetDistance();

    protected override string GetDistanceUnit() => "miles";
    protected override string GetSpeedUnit() => "mph";
}

class Program{
    static void Main(){
        List<Activity> activities = new List<Activity>{
            new Running(new DateTime(2022, 11, 3), 30, 3.0),
            new Cycling(new DateTime(2022, 11, 5), 45, 15.0),
            new Swimming(new DateTime(2022, 11, 7), 40, 30)
        };

        foreach (var activity in activities){
            Console.WriteLine(activity.GetSummary());
        }
    }
}
