using System;

// Deconstruction in C# lets you unpack data structures like tuples or
// custom types into separate variables in a single line.

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Deconstruct(out int x, out int y)
    {
        x = X;
        y = Y;
    }
}

class Deconstructor
{
    public static void Main()
    {
        Point point = new Point { X = 5, Y = 6 };

        // Deconstruct the point object
        (int x, int y) = point;

        Console.WriteLine($"X: {x}, Y: {y}"); // Prints: X: 5, Y: 10
    }
}