public abstract class Shape{
    public string Color { get; set; }

    // Constructor to set the color
    public Shape(string color){
        Color = color;
    }

    // Abstract method to be overridden by derived classes to calculate the area
    public abstract double GetArea();
}
