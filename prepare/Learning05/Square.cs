public class Square : Shape{
    private double _side;

    // Constructor to initialize color and side
    public Square(string color, double side) : base(color){
        _side = side;
    }

    // Override the GetArea method to return the area of the square
    public override double GetArea(){
        return _side * _side;
    }
}
