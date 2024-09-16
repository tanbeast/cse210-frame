using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your grade percentage?");
        int percent = int.Parse(Console.ReadLine());
        string sign = "+";
        string letter = "";
        
        if(percent >= 90){
            letter = "A";
        }else if(percent >= 80){
            letter = "B";
        }else if(percent >= 70){
            letter = "C";
        }else if(percent >= 60){
            letter = "D";
        }else{
            letter = "F";
        }

        int number = percent % 10;
        if (number >= 7){
            sign = "+";
        }else if (number <= 3){
            sign = "-";
        }if (percent >= 93){
            sign = "";
        }if (percent <= 60){
            sign = "";
        }

        Console.Write($"your grade is {letter}{sign}");
    }
}