class GenericMethod
{

    public static void Swap<T>(ref T a, ref T b)
    {
        T temp;
        temp = a;
        a = b;
        b = temp;
    }

    public static void Main()
    {
        int a = 60; int b = 40;
        Console.WriteLine("Before swapping: {0} {1}", a, b);

        Swap<int>(ref a, ref b);
        Console.WriteLine("After swapping: {0} {1}", a, b);

    }
}