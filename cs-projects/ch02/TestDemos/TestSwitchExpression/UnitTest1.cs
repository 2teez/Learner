using NUnit.Framework;

namespace SwitchExpressionTests
{

    [TestFixture]
    class SwitchExpressionTest
    {
        [Test]
        public void CheckFirstDay()
        {
            Assert.That(
            SwitchExpression.CheckExperssion.TwelveDaysOfChristmasSongs(),
            Does.StartWith("that"));
        }

        [Test]
        public void CheckEveryOtherDay()
        {
            Assert.That(
            SwitchExpression.CheckExperssion.TwelveDaysOfChristmasSongs(1),
            Does.StartWith("have"));
        }
        [Test]
        public void CheckPreferedTestFunction()
        {
            SwitchExpression.CheckExperssion.SayEveryDay(5);
        }
    }
}

namespace SwitchExpression
{
    public class CheckExperssion
    {
        public static string TwelveDaysOfChristmasSongs(int day = 0) => day switch
        {
            1 => "have a heart",
            _ => "that is all the songs",
        };

        public static void SayEveryDay(int day) => Assert.That(
            TwelveDaysOfChristmasSongs(day), Does.EndWith("songs"));

    }
}
