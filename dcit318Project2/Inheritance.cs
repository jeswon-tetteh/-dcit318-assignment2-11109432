using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}


class Bird : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Chirp");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();
        Bird bird = new Bird();

        animal.MakeSound();
        dog.MakeSound();
        cat.MakeSound();
        bird.MakeSound();
    }
}