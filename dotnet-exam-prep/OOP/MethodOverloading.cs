// Method overloading allows defining multiple methods in the same class with same name but
// different parameter lists(number, types or order of parameters)

public class MethodOverloading
{
    // Add method with two integer parameters
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Add method with two double parameters (overload)
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Add method with three integer parameters (another overload)
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public static void Main()
    {
        MethodOverloading calc = new MethodOverloading();
        int sum1 = calc.Add(5, 3); // Calls Add(int, int)
        double sum2 = calc.Add(2.5, 1.7); // Calls Add(double, double)
        int sum3 = calc.Add(10, 20, 30); // Calls Add(int, int, int)

        Console.WriteLine($"Sum of 5 and 3: {sum1}");
        Console.WriteLine($"Sum of 2.5 and 1.7: {sum2}");
        Console.WriteLine($"Sum of 10, 20, and 30: {sum3}");
    }
}