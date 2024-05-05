public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Generic animal sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound() // Override method with specific behavior
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        base.MakeSound(); // base class method
        Console.WriteLine("Meow!");
    }
}

public class MethodOverriding
{
    public static void Main()
    {
        Animal dog = new Dog();
        Animal cat = new Cat();
        dog.MakeSound();
        cat.MakeSound();
    }
}