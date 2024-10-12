using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int input = 0;
        while(input != 5){
            Console.Write("PLease select one of the following choices:\n1. Write \n2. Display \n3. Load \n4.Save \n5.Quit \nWhat would you like to do? ");
            input = int.Parse(Console.ReadLine());
            if (input == 1){
                Write write1 = new Write();
                write1.WriteToFile();
            }if (input == 2){
                Display display1 = new Display();
                display1.Read();
            }if (input == 3){
                
            }if (input == 4){
                Load load1 = new Load();
                string file = load1.FileName();
                load1.LoadFile(file);
            }
        }
    }
}