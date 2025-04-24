using DataStructures.DataStructuresImpl;

namespace TestDataStructures.DataStructuresImplTest
{
    [TestFixture]
    public class DoublyLinkedListImplTests
    {
        [Test]
        public void Size_EmptyList_ReturnsZero()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();

            // Act & Assert
            Assert.AreEqual(0, list.Size());
        }

        [Test]
        public void Size_AfterAddingElements_ReturnsCorrectSize()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();

            // Act
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            // Assert
            Assert.AreEqual(3, list.Size());
        }

        [Test]
        public void IsEmpty_NewList_ReturnsTrue()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();

            // Act & Assert
            Assert.IsTrue(list.IsEmpty());
        }

        [Test]
        public void IsEmpty_AfterAddingElement_ReturnsFalse()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(1);

            // Act & Assert
            Assert.IsFalse(list.IsEmpty());
        }

        [Test]
        public void IsEmpty_AfterClearingList_ReturnsTrue()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(1);
            list.AddLast(2);

            // Act
            list.Clear();

            // Assert
            Assert.IsTrue(list.IsEmpty());
        }

        [Test]
        public void Clear_ListWithElements_MakesListEmpty()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            // Act
            list.Clear();

            // Assert
            Assert.AreEqual(0, list.Size());
            Assert.IsTrue(list.IsEmpty());
        }

        [Test]
        public void AddLast_EmptyList_AddsElement()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();

            // Act
            list.AddLast(10);

            // Assert
            Assert.AreEqual(1, list.Size());
            Assert.AreEqual(10, list.PeekFirst());
            Assert.AreEqual(10, list.PeekLast());
        }

        [Test]
        public void AddLast_NonEmptyList_AddsElementAtEnd()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(10);

            // Act
            list.AddLast(20);

            // Assert
            Assert.AreEqual(2, list.Size());
            Assert.AreEqual(10, list.PeekFirst());
            Assert.AreEqual(20, list.PeekLast());
        }

        [Test]
        public void AddFirst_EmptyList_AddsElement()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();

            // Act
            list.AddFirst(10);

            // Assert
            Assert.AreEqual(1, list.Size());
            Assert.AreEqual(10, list.PeekFirst());
            Assert.AreEqual(10, list.PeekLast());
        }

        [Test]
        public void AddFirst_NonEmptyList_AddsElementAtBeginning()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddFirst(20);

            // Act
            list.AddFirst(10);

            // Assert
            Assert.AreEqual(2, list.Size());
            Assert.AreEqual(10, list.PeekFirst());
            Assert.AreEqual(20, list.PeekLast());
        }

        [Test]
        public void AddAt_IndexZero_AddsElementAtBeginning()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(20);
            list.AddLast(30);

            // Act
            list.AddAt(0, 10);

            // Assert
            Assert.AreEqual(3, list.Size());
            Assert.AreEqual(10, list.PeekFirst());
        }

        [Test]
        public void AddAt_IndexEqualToSize_AddsElementAtEnd()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(10);
            list.AddLast(20);

            // Act
            list.AddAt(2, 30);

            // Assert
            Assert.AreEqual(3, list.Size());
            Assert.AreEqual(30, list.PeekLast());
        }

        [Test]
        public void AddAt_MiddleIndex_AddsElementInMiddle()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(10);
            list.AddLast(30);

            // Act
            list.AddAt(1, 20);

            // Assert
            Assert.AreEqual(3, list.Size());
            Assert.AreEqual(20, list.RemoveAt(1));
        }

        [Test]
        public void AddAt_InvalidIndex_ThrowsException()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => list.AddAt(-1, 10));
            Assert.Throws<InvalidOperationException>(() => list.AddAt(1, 10));
        }

        [Test]
        public void PeekFirst_EmptyList_ThrowsException()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => list.PeekFirst());
        }

        [Test]
        public void PeekFirst_NonEmptyList_ReturnsFirstElement()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(10);
            list.AddLast(20);

            // Act & Assert
            Assert.AreEqual(10, list.PeekFirst());
        }

        [Test]
        public void PeekLast_EmptyList_ThrowsException()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => list.PeekLast());
        }

        [Test]
        public void PeekLast_NonEmptyList_ReturnsLastElement()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(10);
            list.AddLast(20);

            // Act & Assert
            Assert.AreEqual(20, list.PeekLast());
        }

        [Test]
        public void RemoveFirst_EmptyList_ThrowsException()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => list.RemoveFirst());
        }

        [Test]
        public void RemoveFirst_SingleElementList_MakesListEmpty()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(10);

            // Act
            int removedValue = list.RemoveFirst();

            // Assert
            Assert.AreEqual(10, removedValue);
            Assert.IsTrue(list.IsEmpty());
        }

        [Test]
        public void RemoveFirst_MultipleElementList_RemovesFirstElement()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            // Act
            int removedValue = list.RemoveFirst();

            // Assert
            Assert.AreEqual(10, removedValue);
            Assert.AreEqual(2, list.Size());
            Assert.AreEqual(20, list.PeekFirst());
        }

        [Test]
        public void RemoveLast_EmptyList_ThrowsException()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => list.RemoveLast());
        }

        [Test]
        public void RemoveLast_SingleElementList_MakesListEmpty()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(10);

            // Act
            int removedValue = list.RemoveLast();

            // Assert
            Assert.AreEqual(10, removedValue);
            Assert.IsTrue(list.IsEmpty());
        }

        [Test]
        public void RemoveLast_MultipleElementList_RemovesLastElement()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            // Act
            int removedValue = list.RemoveLast();

            // Assert
            Assert.AreEqual(30, removedValue);
            Assert.AreEqual(2, list.Size());
            Assert.AreEqual(20, list.PeekLast());
        }

        [Test]
        public void Remove_ExistingValue_RemovesElementAndReturnsTrue()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            // Act
            bool result = list.Remove(20);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(2, list.Size());
            Assert.IsFalse(list.Contains(20));
        }

        [Test]
        public void Remove_NonExistingValue_ReturnsFalse()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(10);
            list.AddLast(20);

            // Act
            bool result = list.Remove(30);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(2, list.Size());
        }

        [Test]
        public void RemoveAt_ValidIndex_RemovesElementAtIndex()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            // Act
            int removedValue = list.RemoveAt(1);

            // Assert
            Assert.AreEqual(20, removedValue);
            Assert.AreEqual(2, list.Size());
            Assert.IsFalse(list.Contains(20));
        }

        [Test]
        public void RemoveAt_InvalidIndex_ThrowsException()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(10);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => list.RemoveAt(-1));
            Assert.Throws<InvalidOperationException>(() => list.RemoveAt(1));
        }

        [Test]
        public void IndexOf_ExistingValue_ReturnsCorrectIndex()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            // Act & Assert
            Assert.AreEqual(0, list.IndexOf(10));
            Assert.AreEqual(1, list.IndexOf(20));
            Assert.AreEqual(2, list.IndexOf(30));
        }

        [Test]
        public void IndexOf_NonExistingValue_ReturnsMinusOne()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(10);
            list.AddLast(20);

            // Act & Assert
            Assert.AreEqual(-1, list.IndexOf(30));
        }

        [Test]
        public void Contains_ExistingValue_ReturnsTrue()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(10);
            list.AddLast(20);

            // Act & Assert
            Assert.IsTrue(list.Contains(10));
            Assert.IsTrue(list.Contains(20));
        }

        [Test]
        public void Contains_NonExistingValue_ReturnsFalse()
        {
            // Arrange
            var list = new DoublyLinkedListImpl();
            list.AddLast(10);
            list.AddLast(20);

            // Act & Assert
            Assert.IsFalse(list.Contains(30));
        }

        [Test]
        public void SequentialOperations_WorkCorrectly()
        {
            // This test checks that a sequence of operations works correctly
            var list = new DoublyLinkedListImpl();

            // Add elements
            list.AddLast(10);
            list.AddFirst(5);
            list.AddLast(15);

            // Check state
            Assert.AreEqual(3, list.Size());
            Assert.AreEqual(5, list.PeekFirst());
            Assert.AreEqual(15, list.PeekLast());

            // Remove elements
            Assert.AreEqual(5, list.RemoveFirst());
            Assert.AreEqual(15, list.RemoveLast());

            // Final state
            Assert.AreEqual(1, list.Size());
            Assert.AreEqual(10, list.PeekFirst());
            Assert.AreEqual(10, list.PeekLast());
        }
    }
}