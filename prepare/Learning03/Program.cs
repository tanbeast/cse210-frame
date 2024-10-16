using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction one = new Fraction();
        one.Test();
        Console.WriteLine(one.GetDecimalValue());
        Console.WriteLine(one.GetFractionString());
        
        Fraction two = new Fraction();
        two.Test(5);
        Console.WriteLine(two.GetDecimalValue());
        Console.WriteLine(two.GetFractionString());
        
        Fraction three = new Fraction();
        three.Test(6,7);
        Console.WriteLine(three.GetDecimalValue());
        Console.WriteLine(three.GetFractionString());
    }
}