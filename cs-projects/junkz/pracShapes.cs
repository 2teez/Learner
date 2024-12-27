using System;

class TestShapes
{
    public static void Main(string[] args)
    {
        var shapes = new IShape[] { new Circle(), new Rectangle(), new Square() };
        for (int i = 0; i < shapes.Length; i++)
        {
            shapes[i].PrintProperties();
            PrintShapes((Shape)shapes[i]);
        }

        var circle = new Circle();
        Console.WriteLine(circle.Radius);
        Console.WriteLine(circle);
        circle.Radius = 2.5;
        Console.WriteLine(circle.Radius);
        Console.WriteLine(circle);
    }

    static void PrintShapes(Shape shape)
    {
        Console.WriteLine(shape);
    }
}

interface IShape
{
    double Area();
    double Perimeter();
    void PrintProperties()
    {
        Console.Write("From interface... ~>");
        Console.WriteLine(
        $"{this.GetType().Name} {{Area: {this.Area():#.00}, Perimeter: {this.Perimeter():#.##}}}");
    }
}

abstract class Shape : IShape
{
    public abstract double Area();
    public abstract double Perimeter();
    public override string ToString()
    {
        return $"{this.GetType().Name} {{Area: {this.Area():##.00}, Perimeter: {this.Perimeter():0#.##}}}";
    }
}

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public Rectangle() : this(5.5, 1.25) { }

    public override double Area()
    {
        return this.length * this.width;
    }
    public override double Perimeter()
    {
        return 2.0 * (this.length + this.width);
    }
}

sealed class Square : Rectangle
{
    private double length;

    public Square(double length) : base(length, length)
    {
        this.length = length;
    }

    public Square() : this(5.5) { }
}

class Circle : Shape
{
    private double radius;

    public double Radius
    {
        get
        {
            return radius;
        }
        set
        {
            if (value < 0) value = 1.25;
            radius = value;
        }
    }
    private const double PI = 22.0 / 7.0;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public Circle() : this(1.235) { }

    public override double Area() => PI * this.radius * this.radius;

    public override double Perimeter() => 2.0 * PI * this.radius;

    public void PrintProperties()
    {
        Console.WriteLine($"{this.GetType().Name}");
    }
}
