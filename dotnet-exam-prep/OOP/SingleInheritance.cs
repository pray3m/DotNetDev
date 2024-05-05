using System;

class Animal2
{
    public void makeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog2 : Animal2 // inherits from Animal
{
    public void Bark()
    {
        Console.WriteLine("Wooof !");
    }
}

public class SingleInheritance
{
    public static void Main()
    {
        Dog2 myDog = new Dog2();
        myDog.makeSound(); // Animal makes a sound
        myDog.Bark(); // Wooof !
    }

    /* OUTPUT : 
    Animal makes a sound
    Wooof !
    */

}