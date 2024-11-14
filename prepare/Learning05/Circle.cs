public class Circle : Shape{
    private double _radius;

    // Constructor to initialize color and radius
    public Circle(string color, double radius) : base(color){
        _radius = radius;
    }

    // Override the GetArea method to return the area of the circle
    public override double GetArea(){
        return Math.PI * _radius * _radius;
    }
}
