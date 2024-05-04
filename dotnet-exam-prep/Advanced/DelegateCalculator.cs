using System;

// declare a delegate type
delegate int MathOperation(int a, int b);

class Calculator
{

    // method that matches the delegate signature
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static void Main()
    {
        // instantiate the delegate with the Add method
        MathOperation calculator = Add;

        // invoke the delegate
        int result = calculator(34, 35);
        Console.WriteLine("After addition : {0}", result);

        calculator = Subtract;
        result = calculator(45, 33);
        Console.WriteLine("After subtraction: {0}", result);
    }

}