//Indexer is a special type of property that allows a class or struct to be accessed like an array.

class IndexerClass
{
    public string[] names = new string[10];

    // Defining indexer with this keyword
    public string this[int index]
    {
        get
        {
            return names[index];
        }
        set
        {
            names[index] = value;
        }
    }

    public static void Main()
    {
        IndexerClass team = new IndexerClass();
        team[0] = "Prem";
        Console.WriteLine(team[0]);
    }
}