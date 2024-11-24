public class EternalGoal : Goal{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent(){
        Console.WriteLine($"Goal {Name} recorded! You've earned {Points} points.");
    }

    public override bool IsCompleted() => false;  // Eternal goals are never completed

    public override void DisplayGoalStatus(){
        Console.WriteLine($"[ ] {Name}: {Description} (Eternal)");
    }
}
