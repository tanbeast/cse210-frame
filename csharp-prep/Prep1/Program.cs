using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your first name? ");
        string Fname = Console.ReadLine();
        Console.Write("what is your last name? ");
        string lname = Console.ReadLine();
        Console.Write($"Your name is {lname}, {Fname} {lname}");
    }
}