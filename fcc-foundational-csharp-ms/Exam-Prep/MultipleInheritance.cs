// Worker , Manager  => Supervisor

interface IWorker
{
    void Work();
}

interface IManager
{
    void Manage();
}

class Supervisor : IWorker, IManager
{
    public void Work()
    {
        Console.WriteLine("Supervisor is working...");
    }

    public void Manage()
    {
        Console.WriteLine("Supervisor is managing...");
    }
}

class MultipleInheritance
{
    public static void Main()
    {
        Supervisor s = new Supervisor();
        s.Work();
        s.Manage();
    }
}