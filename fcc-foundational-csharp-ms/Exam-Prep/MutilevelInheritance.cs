// Animal - Eat 
// Dog - Bark
// BabyDog - Play 
// BabyDog inherits from Dog ; inherits from Animal

using System;


class Animal1
{
    public void Eat()
    {
        Console.WriteLine("Animal eats!");
    }
}

class Dog1 : Animal1
{
    public void Bark()
    {
        Console.WriteLine("Barking.....");
    }
}

class BabyDog1 : Dog1
{
    public void Play()
    {
        Console.WriteLine("playing....");
    }
}

public class MultilevelInheritance
{
    public static void Main()
    {
        BabyDog1 pup = new BabyDog1();
        pup.Bark();
        pup.Eat();
        pup.Play();
    }
}
