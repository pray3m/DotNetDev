// There are two types of delegate : Single cast and multi-cast

// Single-cast delegate : They hold the reference to only one method at a time

using System;

// declare a delegate type
delegate int MathOperation(int a, int b);

class SingleCastDelegate
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
        MathOperation calculator = new MathOperation(Add);

        // invoke the delegate
        int result = calculator(34, 35);
        Console.WriteLine("After addition : {0}", result);

        // re-assign the delegate to Subtract method
        calculator = Subtract;
        result = calculator(45, 33);
        Console.WriteLine("After subtraction: {0}", result);
    }

}