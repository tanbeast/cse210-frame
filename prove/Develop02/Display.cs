public class Display{
    public void Read(){
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines){
            Console.WriteLine(line);
        }
    }
}