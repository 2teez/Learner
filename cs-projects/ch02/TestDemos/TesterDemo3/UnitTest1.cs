namespace TesterDemo3;

using NUnit.Framework;
using System.IO;
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
    [Ignore("This was tested on the previous general method for area")]
    public void CalculateCircleArea()
    {
        Assert.That(shapes["circle"].CalculateArea(), Is.EqualTo(89.3).Within(0.05));
    }

    [Test]
    public void CalculateCirclePerimeter()
    {
        Assert.That(shapes["circle"].CalculatePerimeter(), Is.AtLeast(32).Within(0.01),
            shapes["circle"].ToString());
    }
    [Test]
    public void CalculateSquareArea()
    {
        Assert.That(shapes["square"].CalculateArea(), Is.EqualTo(25).Within(0.05));
    }

    [Test]
    public void CalculateSquarePerimeter()
    {
        Assert.That(shapes["square"].CalculatePerimeter(), Is.AtLeast(19).Within(0.01));
    }

    [Test]
    [Ignore("Checking a wrong directive path by default")]
    public void TestOpenedFile()
    {
        Stream actualFile = File.OpenRead("Shapes.cs");
        Stream expectedFile = File.OpenRead("./TesterDemo3.csproj");
        Assert.That(actualFile, Is.EqualTo(expectedFile));
    }
}
