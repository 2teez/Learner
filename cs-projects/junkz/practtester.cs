using System;
namespace Shapes
{
    public class MainTester
    {
        static void Main(string[] args)
        {
            var shapes = new Shape[] {
            new Circle(radius: 5.23),
            new Triangle(2.5, 5),
            //new Rectangle(),
            //new Square(length: 5),
        };

            foreach (var shape in shapes) Console.WriteLine(shape);
        }
    }

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
}