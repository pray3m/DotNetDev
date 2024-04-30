using System;

class Animal
{
    public void makeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal // inherits from Animal
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
        Dog myDog = new Dog();
        myDog.makeSound(); // Animal makes a sound
        myDog.Bark(); // Wooof !
    }

    /* OUTPUT : 
    Animal makes a sound
    Wooof !
    */

}