using System;

class Program{
    static void Main(string[] args){
        Assignment one = new Assignment("David Walls", "Multiplication");
        Console.WriteLine(one.GetSummary());

        Math two = new Math("kristy Wood", "Fractions", "6.8", "3-29");
        Console.WriteLine(two.GetSummary());
        Console.WriteLine(two.GetHomeworkList());

        Writing three = new Writing("Mary Mack", "History", "The Causes of Civl War");
        Console.WriteLine(three.GetSummary());
        Console.WriteLine(three.GetWritingInformation());
    }
}