using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Write{
    public List<string> _list = new List<string> {
        "If I had one thing I could do over today, what would it be?",
        "What was the strongest emotion I felt today?",
        "How did I see the hand of the Lord in my life today?",
        "What was the best part of my day?",
        "Who was the most interesting person I interacted with today?"
    };

    public object selectedPrompt { get; private set; }

    public void WriteToFile(){
        string fileName = "myFile.txt";

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        using (StreamWriter outputFile = new StreamWriter(fileName, true)){
            Random rnd = new Random();
            int index = rnd.Next(0, _list.Count);
            string selectedPrompt = _list[index];

            Console.WriteLine(selectedPrompt);
            Console.Write("> ");
            string text = Console.ReadLine(); 
            outputFile.WriteLine($"{dateText} - {selectedPrompt} \n{text}\n"); 
        }
    }
}