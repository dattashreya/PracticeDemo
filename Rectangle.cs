public class Rectangle : Shape {
    public double length { get; set; }
    public double breadth { get; set; }
    public Rectangle(double l, double b) {
        length = l;
        breadth = b;
    }
    public override double area() {
        return length * breadth;
    }
}
