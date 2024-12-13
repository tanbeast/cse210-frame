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
