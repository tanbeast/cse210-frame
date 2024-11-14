
using System;

class Program{
    static void Main(string[] args){
        // Create a list to hold the shapes
        List<Shape> shapes = new List<Shape>();

        // Add instances of different shapes
        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Circle("Green", 3));

        // Iterate through the list and display each shape's color and area
        foreach (var shape in shapes){
            Console.WriteLine($"Shape Color: {shape.Color}, Area: {shape.GetArea()}");
        }
    }
}
