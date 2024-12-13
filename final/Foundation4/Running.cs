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
