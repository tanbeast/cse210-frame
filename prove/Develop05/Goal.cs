using System;

public abstract class Goal{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    // Constructor for initializing the name, description, and points
    public Goal(string name, string description, int points){
        Name = name;
        Description = description;
        Points = points;
    }
    // Abstract method to record progress on the goal
    public abstract void RecordEvent();
    // Abstract method to check if the goal is completed
    public abstract bool IsCompleted();
    // Abstract method to display the status of the goal
    public abstract void DisplayGoalStatus();

    // Abstract method to get the current points for the goal
}
