using System;
using Shapes;
using PrintUtil;

namespace PracticeFunctionOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            var rec = new Rectangle((int)3.5, 2);
            var sq = new Square { };

            sq.Pp();
            rec.Pp();

            rec.GetSquareFromRectangle().Pp();
            sq.GetSquareFromRectangle().Pp();

            var ashape = new { Length = 3.6, Height = 5 };
            ashape.ToString().Pp();

            var sh = Triangle.BuildAShape(2.5, 1.35);
            sh.Pp();
            sh.PrintAll();
        }
    }
}

namespace Shapes
{
    class Rectangle
    {
        private double height;
        private readonly double weight;
        public Rectangle() : this(3, 2) { }
        public Rectangle(int height, double weight)
        {
            Height = height;
            this.weight = weight;
        }
        public double Height { get => height; set => height = value; }
        public static implicit operator double(Rectangle rec) => rec.Height;
        public Square GetSquareFromRectangle() => new Square(Height);
        public static explicit operator Rectangle(double value) => new Rectangle((int)value, value);
        public override string ToString() => string.Format(
            " {0} => Height: {1}, Width: {2}", this.GetType().Name, height, weight);
    }

    class Square : Rectangle
    {
        private readonly int length;
        public Square() : this(1.0) { }
        public Square(double length) : base((int)length, length)
        {
            this.length = (int)length;
        }
        // not allowed in C#
        //public static explicit operator Square(Rectangle rec) => new Square(rec.Height);
    }

    static class Triangle
    {
        public static object BuildAShape(double length, double width)
        {
            return new { Length = length, Width = width };
        }
    }
}

namespace PrintUtil
{
    static class Printer
    {
        public static void Pp(this object obj, System.Action<object> fn = null)
        {
            fn ??= Console.WriteLine;
            fn(obj);
        }
        public static void PrintAll(this object obj)
        {
            Console.WriteLine("{0} -> {1}", obj.GetType().Name, obj.GetType().BaseType);
        }
    }
}
