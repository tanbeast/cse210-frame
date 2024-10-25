using System;

class Program{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(reference, scriptureText);

        Console.Clear();
        scripture.Display();

        while (true)
        {
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            string userInput = Console.ReadLine().Trim().ToLower();

            if (userInput == "quit"){
                break;
            }
            scripture.HideRandomWords();
            Console.Clear();
            scripture.Display();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden! You've completed the scripture memorization.");
                break;  
            }
        }
    }
}