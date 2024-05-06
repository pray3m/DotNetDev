// declare a delegate type for the event
public delegate void DelEventHandler();

class EventsDemo
{
    // declare the event using the event keyword
    public static event DelEventHandler add;

    static void USA()
    {
        Console.WriteLine("USA");
    }

    static void India()
    {
        Console.WriteLine("India");
    }

    public static void Main()
    {
        add += new DelEventHandler(USA);
        add += new DelEventHandler(India);
        add.Invoke();

    }
}