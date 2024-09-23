using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the program");
        }
        static string PromptUserName(){
            Console.Write("PLease enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber(){
            Console.Write("PLease enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquareNumber(int number){
            int squared = number * number;
            return squared;
        }
        static void DisplayResult(string name, int number){
            Console.WriteLine($"{name}, the square of your favorite number is {number}.");
        }
        
        DisplayWelcome();
        string name = PromptUserName();
        int number = SquareNumber(PromptUserNumber());
        DisplayResult(name,number);

    }
}