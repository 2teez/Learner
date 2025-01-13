using System;
using NUnit.Framework;
//using NUnit.Framework.SyntaxHelpers;

[TestFixture]
public class LargestTest
{
    [Test]
    public void LargestOf3()
    {
        Assert.That(Cmp.Largest(new[] { 8, 7, 9 }), Is.EqualTo(9));
        Assert.That(Cmp.Largest(new[] { 9, 7, 8 }), Is.EqualTo(9));
        Assert.That(Cmp.Largest(new[] { 8, 9, 7 }), Is.EqualTo(9));
    }

    [Test]
    public void One()
    {
        Assert.That(Cmp.Largest(new[] { 1 }), Is.EqualTo(1));
    }

    [Test]
    public void Negative()
    {
        int[] negatives = new int[] { -9, -8, -7 };
        Assert.That(Cmp.Largest(negatives), Is.EqualTo(-7));
    }

    [Test]
    [ExpectedException(typeof(ArgumentException))]
    public void Empty()
    {
        Cmp.Largest(new int[] { });
    }
}

class Cmp
{
    public static T Largest<T>(T[] values) where T : IComparable<T>
    {
        if (values.Length == 0) throw new ArgumentException("Empty List.");
        var result; // = values[0];
        for (int index = 1; index < values.Length; ++index)
        {
            if (values[index].CompareTo(result) > 0)
            {
                result = values[index];
            }
        }
        return result;
    }
}
