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
                StringFunctionsTest.StringExtraFunctions.GetLatin(
                    "hello, forever"), Is.EqualTo("ellohay oreverfay"));
        }

        [Test]
        [Ignore("Didn't want to run this...")]
        public void TestGetPigLatinException()
        {
            var err = Assert.Throws<CustomStringException.StringLengthException>(
                () => StringFunctionsTest.StringExtraFunctions.GetLatin("")
            );
            Assert.That(err.Message, Does.Contain("Length"));
        }
    }
}

namespace StringFunctionsTest
{
    using CustomStringException;
    using System.Text;

    class StringExtraFunctions
    {
        private static string StripStringPuntucations(string str)
        {
            if (char.IsPunctuation(str[str.Length - 1]))
            {
                str = str.Substring(0, str.Length - 1);
            }
            return str;
        }
        private static string GenerateLatinWord(string str)
        {
            if (str.Length <= 1)
            {
                throw new StringLengthException();
            }
            return (str.Substring(1) + str.Substring(0, 1) + "ay");
        }
        public static string GetLatin(string str)
        {
            var sb = new StringBuilder();
            foreach (var word in str.Split())
                sb.Append(GenerateLatinWord(StripStringPuntucations(word)) + " ");
            return sb.ToString().TrimEnd();
        }
    }
}

namespace CustomStringException
{
    class StringLengthException : Exception
    {
        public StringLengthException(
            string title = "StringLengthException",
            string err = "Length of the string can't be 0 or 1.") : base(err)
        {
            Console.WriteLine(base.Message);
            Console.Write(title + " :");
            Console.WriteLine(err);
        }
        //public StringLengthException() : this(GetType().FullName, "Length of the string can't be 0 or 1."){}
    }
}
