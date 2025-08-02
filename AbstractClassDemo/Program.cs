using System;

// Abstract base class Shape
public abstract class Shape
{
    public abstract double GetArea();
}

// Derived class Circle
public class Circle : Shape
{
    private double radius;
    
    public Circle(double radius)
    {
        this.radius = radius;
    }
    
    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

// Derived class Rectangle
public class Rectangle : Shape
{
    private double width;
    private double height;
    
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    
    public override double GetArea()
    {
        return width * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Abstract Classes and Methods Demo ===");
        
        // Create instances of Circle and Rectangle
        Circle circle = new Circle(5.0);
        Rectangle rectangle = new Rectangle(4.0, 6.0);
        
        // Display their areas
        Console.WriteLine($"Circle with radius 5.0:");
        Console.WriteLine($"Area = {circle.GetArea():F2}");
        
        Console.WriteLine($"\nRectangle with width 4.0 and height 6.0:");
        Console.WriteLine($"Area = {rectangle.GetArea():F2}");
        
        // Demonstrate polymorphism with abstract class
        Console.WriteLine("\n=== Polymorphism with Abstract Classes ===");
        Shape[] shapes = { new Circle(3.0), new Rectangle(2.5, 4.5) };
        
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetType().Name} Area = {shape.GetArea():F2}");
        }
    }
}
