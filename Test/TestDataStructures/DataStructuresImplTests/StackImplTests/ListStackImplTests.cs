using DataStructures.DataStructuresImpl.StackImpl;

namespace TestDataStructures.DataStructuresImplTests.StackImplTests
{
    [TestFixture]
    public class ListStackImplTests
    {
        [Test]
        public void TestBasicStackOperations()
        {
            // Arrange
            var stack = new ListStackImpl<int>();

            // Assert initial state
            Assert.IsTrue(stack.IsEmpty(), "New stack should be empty");

            // Act & Assert - Push operations
            stack.Push(10);
            Assert.IsFalse(stack.IsEmpty(), "Stack should not be empty after push");
            Assert.AreEqual(10, stack.Peek(), "Peek should return the last pushed item");

            stack.Push(20);
            Assert.AreEqual(20, stack.Peek(), "Peek should return the last pushed item");

            stack.Push(30);
            Assert.AreEqual(30, stack.Peek(), "Peek should return the last pushed item");

            // Act & Assert - Pop operations
            Assert.AreEqual(30, stack.Pop(), "Pop should return the last pushed item");
            Assert.AreEqual(20, stack.Peek(), "Peek should return the new top item after pop");

            Assert.AreEqual(20, stack.Pop(), "Pop should return the last pushed item");
            Assert.AreEqual(10, stack.Peek(), "Peek should return the new top item after pop");

            Assert.AreEqual(10, stack.Pop(), "Pop should return the last pushed item");
            Assert.IsTrue(stack.IsEmpty(), "Stack should be empty after all items are popped");
        }

        [Test]
        public void TestStackEdgeCases()
        {
            // Arrange
            var stack = new ListStackImpl<string>();

            // Assert initial state
            Assert.IsTrue(stack.IsEmpty(), "New stack should be empty");

            // Act & Assert - Empty stack exceptions
            Assert.Throws<InvalidOperationException>(() => stack.Pop(),
                "Pop on empty stack should throw InvalidOperationException");

            Assert.Throws<InvalidOperationException>(() => stack.Peek(),
                "Peek on empty stack should throw InvalidOperationException");

            // Test with string type
            stack.Push("first");
            stack.Push("second");
            Assert.AreEqual("second", stack.Pop(), "Pop should return the correct string value");
            Assert.AreEqual("first", stack.Pop(), "Pop should return the correct string value");
            Assert.IsTrue(stack.IsEmpty(), "Stack should be empty after all items are popped");

            // Test push after empty
            stack.Push("new item");
            Assert.IsFalse(stack.IsEmpty(), "Stack should not be empty after push");
            Assert.AreEqual("new item", stack.Peek(), "Peek should return the correct value");

            // Test null values (if applicable for the type)
            var nullStack = new ListStackImpl<string>();
            nullStack.Push(null);
            Assert.IsFalse(nullStack.IsEmpty(), "Stack should not be empty after pushing null");
            Assert.IsNull(nullStack.Peek(), "Peek should return null when null was pushed");
            Assert.IsNull(nullStack.Pop(), "Pop should return null when null was pushed");
            Assert.IsTrue(nullStack.IsEmpty(), "Stack should be empty after popping");
        }

    }
}
