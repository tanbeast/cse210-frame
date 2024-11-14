public class SimpleGoal : Goal{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points){
        _isCompleted = false;
    }

    public override void RecordEvent(){
        if (!_isCompleted){
            _isCompleted = true;
            Console.WriteLine($"Goal {Name} completed! You've earned {Points} points.");
        }
        else{
            Console.WriteLine($"Goal {Name} has already been completed.");
        }
    }

    public override bool IsCompleted() => _isCompleted;

    public override void DisplayGoalStatus(){
        string completionStatus = _isCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{completionStatus} {Name}: {Description}");
    }

    public override int GetCurrentPoints() => _isCompleted ? Points : 0;
}
