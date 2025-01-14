using SwitchExpression;

namespace SwitchExpressionTests
{
    [TestFixture]
    class SwitchExpressionTest
    {
        [Test]
        public void CheckFirstDay()
        {
            Assert.That(
            CheckExperssion.TwelveDaysOfChristmasSongs(),
            Does.StartWith("that"));
        }
    }
}
