using System;
using System.Collections.Generic;

public class Breathing : Base{
    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run(){
        StartMessage();
        int elapsedTime = 0;
        while (elapsedTime < Duration){
            Console.WriteLine("Breathe in...");
            Program.LoadingAnimation(2);
            elapsedTime += 2;

            Console.WriteLine("Breathe out...");
            Program.LoadingAnimation(2);
            elapsedTime += 2;
        }
        EndMessage();
    }
}