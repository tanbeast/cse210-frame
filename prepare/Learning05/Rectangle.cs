public class Rectangle : Shape{
    private double _width;
    private double _height;

    // Constructor to initialize color, width, and height
    public Rectangle(string color, double width, double height) : base(color){
        _width = width;
        _height = height;
    }

    // Override the GetArea method to return the area of the rectangle
    public override double GetArea(){
        return _width * _height;
    }
}
