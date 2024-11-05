using System;
using System.Collections.Generic;
public abstract class Base
{
    protected string Name { get; }
    protected string Description { get; }
    protected int Duration { get; set; }

    protected Base(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public virtual void StartMessage()
    {
        Console.WriteLine($"Starting {Name} Activity");
        Console.WriteLine(Description);
        Console.Write("Enter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Program.LoadingAnimation(3);
    }

    public virtual void EndMessage()
    {
        Console.WriteLine("Great job! You completed the activity.");
        Console.WriteLine($"You completed {Name} Activity for {Duration} seconds.");
        Program.LoadingAnimation(3);
    }

    public abstract void Run();
}