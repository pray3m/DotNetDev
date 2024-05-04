class Rectangle
{
    private double length;
    private double breadth;

    public Rectangle(double l, double b)
    {
        this.length = l;
        this.breadth = b;
        Console.WriteLine($" Rectangle created having l={l} and b={b} ");
    }

    public double calcArea()
    {
        return length * breadth;
    }

    ~Rectangle()
    {
        Console.WriteLine("Rectangle Destroyed.");
    }
}

class RectangleConstructor
{
    public static void Main()
    {
        // creating the rectangle using the constructor
        Rectangle rectangle = new Rectangle(5, 6);
        double area = rectangle.calcArea();
        Console.WriteLine("Area of rectangle is : {0}", area);

        // deconstructor would be called automatically when the object is no longer in use
    }
}