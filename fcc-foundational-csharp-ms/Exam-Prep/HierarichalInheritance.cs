// Shape =>  Circle , Square

using System;

class Shape
{
    public void diplayMessage()
    {
        Console.WriteLine("This is a shape");
    }
}

class Circle : Shape
{
    public void drawCircle()
    {
        Console.WriteLine("Drawing circle...");
    }
}

class Square : Shape
{
    public void drawSquare()
    {
        Console.WriteLine("Drawing square");
    }
}

class HeirarichalInheritance
{
    public static void Main()
    {
        Circle c1 = new Circle();
        c1.diplayMessage();
        c1.drawCircle();

        Square s1 = new Square();
        s1.diplayMessage();
        s1.drawSquare();
    }


    /* OUTPUT:
    This is a shape
    Drawing circle...
    
    This is a shape
    Drawing square
    */

}
