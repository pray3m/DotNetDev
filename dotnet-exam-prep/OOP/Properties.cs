// Properties in C# are a special type of member that provides a controlled way to access and modify the
// internal data of a class. They act like public variables but offer more flexibility and control than
// directly exposing fields.

public class Person
{
    private int _id;
    private String _name;
    private int _age;


    // Read-only property for Person ID (cannot be modified)
    public int Id
    {
        get { return _id; }
    }

    // Read-write property for First Name with validation
    public string Name
    {
        get { return _name; }
        set { _name = value.ToUpper(); }
    }

    // Write-only property for Age with setter logic (cannot be directly retrieved)
    public int Age
    {
        set { _age = value; }
    }

    public Person(int id, string name, int age)
    {
        _id = id;
        Name = name;
        Age = age;
    }
}

class Properties
{
    public static void Main()
    {
        Person person = new Person(1, "Prem", 21);

        Console.WriteLine($" id : {person.Id}");
        Console.WriteLine($" name : {person.Name}");
    }
}

