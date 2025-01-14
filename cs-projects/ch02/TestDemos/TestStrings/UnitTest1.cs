using System.Text;

namespace StringTester
{
    [TestFixture]
    class StringTest
    {
        [Test]
        public void TestGetPigLatin()
        {
            Assert.That(
                StringFunctionsTest.StringExtraFunctions.GetPigLatin(
                    "hello, forever"), Is.EqualTo("ellohay oreverfay"));
        }

        [Test]
        [Ignore("Didn't want to run this...")]
        public void TestGetPigLatinException()
        {
            var err = Assert.Throws<CustomStringException.StringLengthException>(
                () => StringFunctionsTest.StringExtraFunctions.GetPigLatin("")
            );
            Assert.That(err.Message, Does.Contain("Length"));
        }

        [Test]
        public void TestReverseGetLatin()
        {
            Assert.That(
                StringFunctionsTest.StringExtraFunctions.ReversePigLatin(
                    "oreverfay"), Is.EqualTo("forever"));
        }
    }
}
