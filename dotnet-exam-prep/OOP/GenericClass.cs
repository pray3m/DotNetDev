class Test<T>
{
    T[] t = new T[5];
    int count = 0;

    public void AddItem(T item)
    {
        if (count < 5)
        {
            t[count] = item;
            count++;
        }
        else
        {
            System.Console.WriteLine("Overflow exists");
        }
    }

    public void DisplayItem()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"The item at index{i} is {t[i]}");
        }
    }
}

class GenericClass
{
    public static void Main()
    {
        Test<int> numbers = new Test<int>();
        numbers.AddItem(10);
        numbers.AddItem(21);
        numbers.AddItem(3);
        numbers.AddItem(4);
        // numbers.AddItem(6);

        numbers.DisplayItem();
    }
}