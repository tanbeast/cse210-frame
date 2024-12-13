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
