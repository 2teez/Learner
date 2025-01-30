using ConcurrencyLibDemo2;

namespace ConcurrencyTestDemo2;

public class Tests
{
    Calculate cal = null;
    [SetUp]
    public void Setup()
    {
        cal = new Calculate { };
    }

    [Test]
    public void TestGreaterThan()
    {
        int firstValue = new Random().Next(1, 10);
        int secondValue = new Random().Next(1, 10);
        Assert.That(cal.GreaterThan(firstValue, secondValue), Is.EqualTo(true));
    }

    [Test]
    public void TestFibonacciNumber6()
    {
        Assert.That(Calculate.Fibonacci(6), Is.EqualTo(8));
    }
}
