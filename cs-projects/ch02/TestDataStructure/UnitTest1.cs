using Stacks;

namespace StackTest
{
    [TestFixture]
    class TestCases
    {
        Stacks.Stack<int> stack;

        [SetUp]
        public void StackSetUp()
        {
            stack = new Stacks.Stack<int>();
        }

        [Test]
        public void TestDefaultSizeOfStack()
        {
            Assert.That(stack.Size, Is.EqualTo(10));
        }

        [Test]
        public void TestAddedItemToStackIndex()
        {
            stack.Push(3);
            stack.Push(10);
            Assert.That(stack[1], Is.EqualTo(10));
        }
        [Test]
        [Ignore("check later -- todo later")]
        public void TestSizeAfterDeletion()
        {
            stack.Pop();
            Assert.That(stack.Size, Is.EqualTo(10));
        }
        [Test]
        [Ignore("check later -- todo later")]
        public void TestPopFunction()
        {
            var pop = stack.Pop();
            Assert.That(pop, Is.EqualTo(3));
        }
    }
}
