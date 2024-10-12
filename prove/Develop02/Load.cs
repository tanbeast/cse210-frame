using System.IO;

public class Load{
    public string FileName(){
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        return fileName;  
    }
    public void LoadFile(string file){
        using (StreamWriter outputFile = new StreamWriter(file, true)){
            string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines){
            outputFile.WriteLine(line); 
        }
        }
    }
}