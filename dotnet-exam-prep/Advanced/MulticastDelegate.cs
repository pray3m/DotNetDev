
// Multicast delegate : Hold references to multiple methods having same signature 
// you can chain multiple methods using the "+=" operator;

public delegate int CalculatorDemo(int x);
class MultiCastDelegate
{
    public static int num = 10;

    static int Add(int x)
    {
        num += x;
        return num;
    }

    static int Multiply(int x)
    {
        num *= x;
        return num;
    }

    public static void Main()
    {
        // instantiate the delegate 
        CalculatorDemo calc = new CalculatorDemo(Add);
        calc += Multiply;

        int result = calc(5);
        Console.WriteLine($"The final result is : {result}");
    }
}