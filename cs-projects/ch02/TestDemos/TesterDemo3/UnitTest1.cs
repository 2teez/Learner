namespace TesterDemo3;

//using NUnit.Framework;
using Shapes;

[TestFixture]
public class TestShapesModel
{
    Dictionary<string, Shape> shapes;

    [SetUp]
    public void TestSetUp()
    {
        shapes = new Dictionary<string, Shape>();
        shapes.Add("circle", new Circle(radius: 5.23));
        shapes.Add("triangle", new Triangle(2.5, 5));
        shapes.Add("rectangle", new Rectangle());
        shapes.Add("square", new Square(_length: 5));
    }

    [Test]
    public void CalculateArea()
    {
        double[] areas = new double[] { 85.9, 6.25, 1.0, 25 };
        var counter = 0;
        foreach (var shape in shapes)
        {
            Assert.That(shapes[shape.Key].CalculateArea(), Is.EqualTo(areas[counter++]).Within(0.05));
        }
    }

    [Test]
    public void CalculateCircleArea()
    {
        Assert.That(shapes["circle"].CalculateArea(), Is.EqualTo(89.3).Within(0.05));
    }
    [Test]
    public void CalculateCirclePerimeter()
    {
        Assert.That(shapes["circle"].CalculatePerimeter(), Is.AtLeast(32).Within(0.01));
    }
}
