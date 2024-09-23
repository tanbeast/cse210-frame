using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 0;
        int sum = 0;

        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do{
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
            sum = sum + number;
        }while(number != 0);

        numbers.Sort();
        int lastNum = numbers.Count - 1;
        float average = sum / lastNum;
        Console.WriteLine($"number of items: {numbers.Count}");
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {numbers[lastNum]}");
    }
}