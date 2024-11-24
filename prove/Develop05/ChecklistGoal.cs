public class ChecklistGoal : Goal{
    private int _timesCompleted;
    private int _goalCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int goalCount)
        : base(name, description, points){
        _goalCount = goalCount;
        _bonus = 0;
        _timesCompleted = 0;
    }

    public ChecklistGoal(string name, string description, int points, int goalCount, int bonus)
        : base(name, description, points){
        _goalCount = goalCount;
        _bonus = bonus;
        _timesCompleted = 0;
    }

    public override void RecordEvent(){
        if (_timesCompleted < _goalCount){
            _timesCompleted++;
            Console.WriteLine($"Goal {Name} recorded! You've earned {Points} points.");

            // If goal is completed, add bonus
            if (_timesCompleted == _goalCount){
                Console.WriteLine($"Congratulations! You've completed the goal. Bonus of {_bonus} points awarded.");
            }
        }
        else{
            Console.WriteLine($"Goal {Name} is already completed.");
        }
    }

    public override bool IsCompleted() => _timesCompleted >= _goalCount;

    public override void DisplayGoalStatus(){
        string completionStatus = _timesCompleted >= _goalCount ? "[X]" : "[ ]";
        Console.WriteLine($"{completionStatus} {Name}: {Description} - Completed {_timesCompleted}/{_goalCount} times");
    }

  
    // Add this method to set the times completed when loading the data
    public void SetTimesCompleted(int timesCompleted){
        _timesCompleted = timesCompleted;
    }

    public int GetTimesCompleted() => _timesCompleted;
    public int GoalCount => _goalCount;
    public int BonusPoints => _bonus;
}
