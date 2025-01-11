using System;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

[TestFixture]
public class LargestTest
{
    [Test]
    public void LargestOf3()
    {
        Assert.That(Cmp.Largest(new[] { 8, 7, 9 }), Is.EqualTo(9));
    }
}
