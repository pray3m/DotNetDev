class RelationalOverload
{
    public int num;
    public string name;

    public static bool operator >(RelationalOverload r1, RelationalOverload r2)
    {
        return r1.num > r2.num;
    }

    public static bool operator <(RelationalOverload r1, RelationalOverload r2)
    {
        return r1.num < r2.num;
    }

    public static void Main()
    {
        RelationalOverload r1 = new RelationalOverload();
        RelationalOverload r2 = new RelationalOverload();
        r1.num = 4;
        r2.num = 5;

        bool r3 = r1 > r2;
        Console.WriteLine(r3);
    }

}