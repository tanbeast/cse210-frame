using System;
using System.Collections.Generic;

public class Listing : Base{
    private static readonly List<string> Prompts = new List<string>
    {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt positive emotions this month?",
            "Who are some of your personal heroes?"
        };

    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Run(){
        StartMessage();
        int elapsedTime = 0;
        Console.WriteLine(Prompts[new Random().Next(Prompts.Count)]);
        Program.LoadingAnimation(3);

        var items = new List<string>();
        while (elapsedTime < Duration){
            Console.Write("List an item: ");
            items.Add(Console.ReadLine());
            elapsedTime += 2;
        }
        Console.WriteLine($"You listed {items.Count} items.");
        EndMessage();
    }
}