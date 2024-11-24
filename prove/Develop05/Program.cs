using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

public class Program{
    private static List<Goal> goals = new List<Goal>();
    private static int totalScore = 0;

    public static void Main(string[] args){
        Console.WriteLine("Goal Tracker Program");

        // Main menu loop
        while (true){
            Console.WriteLine($"\nTotal Score: {totalScore}");
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");

            var choice = Console.ReadLine();

            switch (choice){
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    // 1. Create new goal
    private static void CreateGoal(){
        Console.WriteLine("Enter goal type (Simple, Eternal, Checklist): ");
        var goalType = Console.ReadLine();
        
        Console.WriteLine("Enter goal name: ");
        var name = Console.ReadLine();
        
        Console.WriteLine("Enter goal description: ");
        var description = Console.ReadLine();
        
        Console.WriteLine("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        if (goalType.ToLower() == "simple"){
            goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalType.ToLower() == "eternal"){
            goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalType.ToLower() == "checklist"){
            Console.WriteLine("Enter number of times goal must be completed: ");
            int goalCount = int.Parse(Console.ReadLine());

            Console.WriteLine("How many bouns point will be earned unpon completion");
            int bonus = int.Parse(Console.ReadLine());

            goals.Add(new ChecklistGoal(name, description, points, goalCount, bonus));
        }
        else{
            Console.WriteLine("Invalid goal type.");
        }
    }

    // 2. List goals
    private static void ListGoals(){
        Console.WriteLine("Your Goals:");
        if (goals.Count == 0){
            Console.WriteLine("No goals available.");
        }
        else{
            for (int i = 0; i < goals.Count; i++){
                goals[i].DisplayGoalStatus();
            }
        }
    }

    // 3. Save goals to a text file
    private static void SaveGoals(){
        Console.WriteLine("Enter the filename to save goals to: ");
        var fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName)){
            writer.WriteLine($"{totalScore}");
            foreach (var goal in goals){
                if (goal is SimpleGoal simpleGoal){
                    // Save simple goal: name, description, points, completion status
                    writer.WriteLine($"SimpleGoal|{simpleGoal.Name}|{simpleGoal.Description}|{simpleGoal.Points}|{(simpleGoal.IsCompleted() ? "completed" : "not completed")}");
                }
                else if (goal is EternalGoal eternalGoal){
                    // Save eternal goal: name, description, points
                    writer.WriteLine($"EternalGoal|{eternalGoal.Name}|{eternalGoal.Description}|{eternalGoal.Points}");
                }
                else if (goal is ChecklistGoal checklistGoal){
                    // Save checklist goal: name, description, points, times to complete, times completed
                    writer.WriteLine($"ChecklistGoal|{checklistGoal.Name}|{checklistGoal.Description}|{checklistGoal.Points}|{checklistGoal.GoalCount}|{checklistGoal.GetTimesCompleted()}");
                }
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    // 4. Load goals from a text file
    private static void LoadGoals(){
        Console.WriteLine("Enter the filename to load goals from: ");
        var fileName = Console.ReadLine();

        if (!File.Exists(fileName)){ // if no file exists
            Console.WriteLine("File not found.");
            return;
        }

        using (StreamReader reader = new StreamReader(fileName)){
            string line;
            while ((line = reader.ReadLine()) != null){
                string[] goalData = line.Split('|');

                if (goalData[0] == "SimpleGoal"){
                    var goal = new SimpleGoal(goalData[1], goalData[2], int.Parse(goalData[3]));
                    goals.Add(goal);
                }
                else if (goalData[0] == "EternalGoal"){
                    var goal = new EternalGoal(goalData[1], goalData[2], int.Parse(goalData[3]));
                    goals.Add(goal);
                }
                else if (goalData[0] == "ChecklistGoal"){
                    var goal = new ChecklistGoal(goalData[1], goalData[2], int.Parse(goalData[3]), int.Parse(goalData[4]));
                    goal.SetTimesCompleted(int.Parse(goalData[5])); // Set the times completed
                    goals.Add(goal);
                }
                else{
                    totalScore += int.Parse(goalData[0]);
                }
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }

    // 5. Record event
    private static void RecordEvent(){
        Console.WriteLine("Select a goal to record (enter goal number): ");
        for (int i = 0; i < goals.Count; i++){
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < goals.Count){
            goals[index].RecordEvent();
        }
        else{
            Console.WriteLine("Invalid goal selection.");
        }
    }
    public static void addpoints(int points){
        totalScore += points;
    }

}
