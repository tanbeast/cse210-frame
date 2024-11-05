using System;
using System.Collections.Generic;

class Program{
    public static void LoadingAnimation(int duration){
        for (int i = 0; i < duration; i++){
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    static void Main(string[] args){
        while (true){
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    new Breathing().Run();
                    break;
                case "2":
                    new Reflection().Run();
                    break;
                case "3":
                    new Listing().Run();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}