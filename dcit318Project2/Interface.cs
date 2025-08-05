using System;

interface IMovable
{
    void Move();
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Airplane : IMovable
{
    public void Move()
    {
        Console.WriteLine("Airplane is flying");
    }
}

class Interface
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Airplane airplane = new Airplane();

        car.Move();
        bicycle.Move();
        airplane.Move();
    }
}