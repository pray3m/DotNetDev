// A lambda expression in C# is an anonymous function that can be used to create delegates or
// expression tree types. Lambda expressions provide a concise way to represent methods as expressions. 
// They are particularly useful in LINQ queries, event handling, and other scenarios where a method is expected as a

using System;

class LambdaExpression
{
    public static void Main()
    {

        Func<int, int, int> add = (x, y) => x + y;
        int result = add(3, 5);
        System.Console.WriteLine(result);


        Action<string> greet = (name) =>
        {
            Console.WriteLine($"Hello, {name}!");
        };

        greet("John");

    }
}