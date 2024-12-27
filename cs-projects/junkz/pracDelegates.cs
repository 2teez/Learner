using System;

public delegate double CalculateArea();

class Delegates
{
    public static void Main(string[] args)
    {
        var rect = new Rectangle(2, 6);
        var cir = new Circle(0.34);
        CalculateArea ca;
        ca = new CalculateArea(rect.Area);
        Console.WriteLine($"{rect.GetType().Name}'s area is {ca()}");
        ca = new CalculateArea(cir.Area);
        Console.WriteLine($"{cir.GetType().Name}'s area is {ca()}");
    }
}

public interface IShape
{
    public double Area();
}

public class Rectangle : IShape
{
    private double length;
    private double width;
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }
    public double Area() => this.length * this.width;
}

public class Circle : IShape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double Area() => Math.PI * this.radius * this.radius;
}
