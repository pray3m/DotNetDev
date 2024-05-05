// Operator overloading helps to use the same operator for various operations

class UnaryOverloading
{
    public int num;

    public static UnaryOverloading operator ++(UnaryOverloading u1)
    {
        UnaryOverloading incrementedNum = new UnaryOverloading();
        incrementedNum.num = u1.num + 1;
        return incrementedNum;
    }

    public static void Main()
    {
        UnaryOverloading u1 = new UnaryOverloading();
        u1.num = 10;
        UnaryOverloading u2 = new UnaryOverloading();
        u2 = ++u1;
        System.Console.WriteLine(u2.num);
    }
}