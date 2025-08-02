using System;

// Interface IMovable
public interface IMovable
{
    void Move();
}

// Class Car implementing IMovable
public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Class Bicycle implementing IMovable
public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Interfaces Demo ===");
        
        // Create instances of Car and Bicycle
        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        
        // Call Move() method on each instance
        Console.Write("Car: ");
        car.Move();
        
        Console.Write("Bicycle: ");
        bicycle.Move();
        
        // Demonstrate polymorphism with interfaces
        Console.WriteLine("\n=== Polymorphism with Interfaces ===");
        IMovable[] movableObjects = { new Car(), new Bicycle() };
        
        foreach (IMovable movable in movableObjects)
        {
            Console.Write($"{movable.GetType().Name}: ");
            movable.Move();
        }
    }
}
