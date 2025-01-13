namespace Shapes;

interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

public abstract class Shape : IShape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
    public override string ToString() => $"{{Area: {CalculateArea()},Perimeter: {CalculatePerimeter()}}}";
}

public class Triangle : Shape
{
    private double _base;
    private double height;

    public Triangle(double _base, double height)
    {
        this._base = _base;
        this.height = height;
    }

    public override double CalculateArea() => _base * height / 2.0;
    public override double CalculatePerimeter() => 2.0 * _base + height;
    public new string ToString() => $"{{{this.GetType().Name} - {base.ToString()}}}";
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea() => Math.PI * radius * radius;
    public override double CalculatePerimeter() => 2.0 * Math.PI * radius;
    public new string ToString() => $"{{{this.GetType().Name} - {base.ToString()}}}";
}

public class Rectangle : Shape
{
    private readonly double width,
                   height;
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public Rectangle() : this(1, 1) { }
    public override double CalculateArea() => width * height;
    public override double CalculatePerimeter() => 2.0 * (width + height);
    public new string ToString() => $"{{{this.GetType().Name} - {base.ToString()}}}";

}


public sealed class Square : Rectangle
{
    private readonly double _length;
    public Square(double _length) : base(_length, _length)
    {
        this._length = _length;
    }

    public Square() : this(1) { }
}
