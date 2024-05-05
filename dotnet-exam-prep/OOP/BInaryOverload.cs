// Operator overloading is a compile-time polymorphism. 
// Operator overloading is a feature in object-oriented programming languages like C# that allows you to 
// redefine the behavior of operators when applied to instances of custom types.

class BinaryOperatorOverloading
{
    internal int num;
    internal string? name;


    public static BinaryOperatorOverloading operator +(BinaryOperatorOverloading b1, BinaryOperatorOverloading b2)
    {
        BinaryOperatorOverloading obj = new BinaryOperatorOverloading();
        obj.num = b1.num + b2.num;
        obj.name = b1.name + "  " + b2.name;
        return obj;
    }

    public static void Main()
    {
        BinaryOperatorOverloading b1 = new BinaryOperatorOverloading();
        BinaryOperatorOverloading b2 = new BinaryOperatorOverloading();
        b1.name = "Prem";
        b2.name = "Gautam";
        b1.num = 10;
        b1.num = 20;
        BinaryOperatorOverloading b3 = new BinaryOperatorOverloading();
        b3 = b1 + b2;
        System.Console.WriteLine(b3.num);
        System.Console.WriteLine(b3.name);
    }
}