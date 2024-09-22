using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "yes";
        do{
            Console.WriteLine("Hello Prep3 World!");
            Random randomgenerator = new Random();
            int magicNumber = randomgenerator.Next(1,10);
            int guessNumber = 0;
            int guesses = 1;
            

            Console.WriteLine("guess a number between 1 and 10.");
            do{
                Console.Write("what is your guess:");
                guessNumber = int.Parse(Console.ReadLine());
                if(guessNumber > magicNumber){
                    Console.WriteLine("Lower");
                }else if(guessNumber < magicNumber){
                    Console.WriteLine("Higher");
                }else if(guessNumber == magicNumber){
                    Console.WriteLine($"Good Job you got it in {guesses} guesses!!");
                    Console.Write("Do you want to play again: ");
                    play = Console.ReadLine();
                }else{
                    Console.WriteLine("Try again");
                }
                guesses = guesses += 1;

            }while (guessNumber != magicNumber);}while (play == "yes");
    }
}