//[TestFixture]
//public class LinkedListImplTests
//{
//    private LinkedList<int> list;

//    [SetUp]
//    public void Setup()
//    {
//        list = new LinkedList<int>();
//    }

//    [Test]
//    public void NewList_ShouldBeEmpty()
//    {
//        Assert.IsTrue(list.Empty());
//        Assert.AreEqual(0, list.Size());
//    }

//    [Test]
//    public void Size_ShouldReturnCorrectCount()
//    {
//        Assert.AreEqual(0, list.Size());

//        list.PushFront(1);
//        Assert.AreEqual(1, list.Size());

//        list.PushBack(2);
//        Assert.AreEqual(2, list.Size());

//        list.PopFront();
//        Assert.AreEqual(1, list.Size());

//        list.PopBack();
//        Assert.AreEqual(0, list.Size());
//    }

//    [Test]
//    public void Empty_ShouldReturnTrueWhenEmpty()
//    {
//        Assert.IsTrue(list.Empty());

//        list.PushFront(1);
//        Assert.IsFalse(list.Empty());

//        list.PopFront();
//        Assert.IsTrue(list.Empty());
//    }

//    [Test]
//    public void ValueAt_ShouldReturnCorrectValue()
//    {
//        list.PushBack(1);
//        list.PushBack(2);
//        list.PushBack(3);

//        Assert.AreEqual(1, list.ValueAt(0));
//        Assert.AreEqual(2, list.ValueAt(1));
//        Assert.AreEqual(3, list.ValueAt(2));
//    }

//    [Test]
//    public void ValueAt_ShouldThrowExceptionForInvalidIndex()
//    {
//        list.PushBack(1);

//        Assert.Throws<IndexOutOfRangeException>(() => list.ValueAt(-1));
//        Assert.Throws<IndexOutOfRangeException>(() => list.ValueAt(1));
//    }

//    [Test]
//    public void PushFront_ShouldAddItemToFront()
//    {
//        list.PushFront(1);
//        Assert.AreEqual(1, list.Front());

//        list.PushFront(2);
//        Assert.AreEqual(2, list.Front());
//        Assert.AreEqual(1, list.Back());

//        Assert.AreEqual(2, list.Size());
//    }

//    [Test]
//    public void PopFront_ShouldRemoveAndReturnFrontItem()
//    {
//        list.PushBack(1);
//        list.PushBack(2);

//        Assert.AreEqual(1, list.PopFront());
//        Assert.AreEqual(1, list.Size());
//        Assert.AreEqual(2, list.Front());

//        Assert.AreEqual(2, list.PopFront());
//        Assert.IsTrue(list.Empty());
//    }

//    [Test]
//    public void PopFront_ShouldThrowExceptionWhenEmpty()
//    {
//        Assert.Throws<InvalidOperationException>(() => list.PopFront());
//    }

//    [Test]
//    public void PushBack_ShouldAddItemToBack()
//    {
//        list.PushBack(1);
//        Assert.AreEqual(1, list.Back());

//        list.PushBack(2);
//        Assert.AreEqual(2, list.Back());
//        Assert.AreEqual(1, list.Front());

//        Assert.AreEqual(2, list.Size());
//    }

//    [Test]
//    public void PopBack_ShouldRemoveAndReturnBackItem()
//    {
//        list.PushBack(1);
//        list.PushBack(2);

//        Assert.AreEqual(2, list.PopBack());
//        Assert.AreEqual(1, list.Size());
//        Assert.AreEqual(1, list.Back());

//        Assert.AreEqual(1, list.PopBack());
//        Assert.IsTrue(list.Empty());
//    }

//    [Test]
//    public void PopBack_ShouldThrowExceptionWhenEmpty()
//    {
//        Assert.Throws<InvalidOperationException>(() => list.PopBack());
//    }

//    [Test]
//    public void Front_ShouldReturnFrontItemWithoutRemoving()
//    {
//        list.PushBack(1);
//        list.PushBack(2);

//        Assert.AreEqual(1, list.Front());
//        Assert.AreEqual(2, list.Size());
//    }

//    [Test]
//    public void Front_ShouldThrowExceptionWhenEmpty()
//    {
//        Assert.Throws<InvalidOperationException>(() => list.Front());
//    }

//    [Test]
//    public void Back_ShouldReturnBackItemWithoutRemoving()
//    {
//        list.PushBack(1);
//        list.PushBack(2);

//        Assert.AreEqual(2, list.Back());
//        Assert.AreEqual(2, list.Size());
//    }

//    [Test]
//    public void Back_ShouldThrowExceptionWhenEmpty()
//    {
//        Assert.Throws<InvalidOperationException>(() => list.Back());
//    }

//    [Test]
//    public void Insert_ShouldInsertItemAtIndex()
//    {
//        list.PushBack(1);
//        list.PushBack(3);

//        list.Insert(1, 2);

//        Assert.AreEqual(1, list.ValueAt(0));
//        Assert.AreEqual(2, list.ValueAt(1));
//        Assert.AreEqual(3, list.ValueAt(2));
//        Assert.AreEqual(3, list.Size());
//    }

//    [Test]
//    public void Insert_AtFrontShouldBeSameAsPushFront()
//    {
//        list.PushBack(2);
//        list.Insert(0, 1);

//        Assert.AreEqual(1, list.Front());
//        Assert.AreEqual(2, list.Back());
//    }

//    [Test]
//    public void Insert_AtEndShouldBeSameAsPushBack()
//    {
//        list.PushBack(1);
//        list.Insert(1, 2);

//        Assert.AreEqual(1, list.Front());
//        Assert.AreEqual(2, list.Back());
//    }

//    [Test]
//    public void Insert_ShouldThrowExceptionForInvalidIndex()
//    {
//        Assert.Throws<IndexOutOfRangeException>(() => list.Insert(-1, 1));

//        list.PushBack(1);
//        Assert.Throws<IndexOutOfRangeException>(() => list.Insert(2, 2));
//    }

//    [Test]
//    public void Erase_ShouldRemoveItemAtIndex()
//    {
//        list.PushBack(1);
//        list.PushBack(2);
//        list.PushBack(3);

//        list.Erase(1);

//        Assert.AreEqual(1, list.ValueAt(0));
//        Assert.AreEqual(3, list.ValueAt(1));
//        Assert.AreEqual(2, list.Size());
//    }

//    [Test]
//    public void Erase_FirstItemShouldUpdateHead()
//    {
//        list.PushBack(1);
//        list.PushBack(2);

//        list.Erase(0);

//        Assert.AreEqual(2, list.Front());
//        Assert.AreEqual(1, list.Size());
//    }

//    [Test]
//    public void Erase_LastItemShouldUpdateTail()
//    {
//        list.PushBack(1);
//        list.PushBack(2);

//        list.Erase(1);

//        Assert.AreEqual(1, list.Back());
//        Assert.AreEqual(1, list.Size());
//    }

//    [Test]
//    public void Erase_ShouldThrowExceptionForInvalidIndex()
//    {
//        Assert.Throws<IndexOutOfRangeException>(() => list.Erase(0));

//        list.PushBack(1);
//        Assert.Throws<IndexOutOfRangeException>(() => list.Erase(-1));
//        Assert.Throws<IndexOutOfRangeException>(() => list.Erase(1));
//    }

//    [Test]
//    public void ValueNFromEnd_ShouldReturnCorrectValue()
//    {
//        list.PushBack(1);
//        list.PushBack(2);
//        list.PushBack(3);

//        Assert.AreEqual(3, list.ValueNFromEnd(0)); // Last element
//        Assert.AreEqual(2, list.ValueNFromEnd(1)); // Second-to-last
//        Assert.AreEqual(1, list.ValueNFromEnd(2)); // Third-to-last (first)
//    }

//    [Test]
//    public void ValueNFromEnd_ShouldThrowExceptionForInvalidN()
//    {
//        list.PushBack(1);
//        list.PushBack(2);

//        Assert.Throws<IndexOutOfRangeException>(() => list.ValueNFromEnd(-1));
//        Assert.Throws<IndexOutOfRangeException>(() => list.ValueNFromEnd(2));
//    }

//    [Test]
//    public void Reverse_ShouldReverseList()
//    {
//        list.PushBack(1);
//        list.PushBack(2);
//        list.PushBack(3);

//        list.Reverse();

//        Assert.AreEqual(3, list.ValueAt(0));
//        Assert.AreEqual(2, list.ValueAt(1));
//        Assert.AreEqual(1, list.ValueAt(2));
//        Assert.AreEqual(3, list.Front());
//        Assert.AreEqual(1, list.Back());
//    }

//    [Test]
//    public void Reverse_ShouldHandleSingleElement()
//    {
//        list.PushBack(1);

//        list.Reverse();

//        Assert.AreEqual(1, list.Front());
//        Assert.AreEqual(1, list.Back());
//        Assert.AreEqual(1, list.Size());
//    }

//    [Test]
//    public void Reverse_ShouldHandleEmptyList()
//    {
//        list.Reverse();

//        Assert.IsTrue(list.Empty());
//    }

//    [Test]
//    public void RemoveValue_ShouldRemoveFirstOccurrenceAndReturnTrue()
//    {
//        list.PushBack(1);
//        list.PushBack(2);
//        list.PushBack(2);
//        list.PushBack(3);

//        Assert.IsTrue(list.RemoveValue(2));
//        Assert.AreEqual(3, list.Size());
//        Assert.AreEqual(1, list.ValueAt(0));
//        Assert.AreEqual(2, list.ValueAt(1)); // Second occurrence remains
//        Assert.AreEqual(3, list.ValueAt(2));
//    }

//    [Test]
//    public void RemoveValue_ShouldReturnFalseWhenValueNotFound()
//    {
//        list.PushBack(1);
//        list.PushBack(2);

//        Assert.IsFalse(list.RemoveValue(3));
//        Assert.AreEqual(2, list.Size());
//    }

//    [Test]
//    public void RemoveValue_ShouldReturnFalseForEmptyList()
//    {
//        Assert.IsFalse(list.RemoveValue(1));
//    }

//    [Test]
//    public void RemoveValue_ShouldCorrectlyRemoveFirstElement()
//    {
//        list.PushBack(1);
//        list.PushBack(2);

//        Assert.IsTrue(list.RemoveValue(1));
//        Assert.AreEqual(1, list.Size());
//        Assert.AreEqual(2, list.Front());
//    }

//    [Test]
//    public void RemoveValue_ShouldCorrectlyRemoveLastElement()
//    {
//        list.PushBack(1);
//        list.PushBack(2);

//        Assert.IsTrue(list.RemoveValue(2));
//        Assert.AreEqual(1, list.Size());
//        Assert.AreEqual(1, list.Back());
//    }

//    [Test]
//    public void CombinationTest_ShouldHandleMultipleOperations()
//    {
//        // Test a sequence of operations
//        list.PushBack(1);
//        list.PushBack(2);
//        list.PushFront(0);

//        Assert.AreEqual(0, list.Front());
//        Assert.AreEqual(2, list.Back());
//        Assert.AreEqual(3, list.Size());

//        list.Insert(2, 3);
//        Assert.AreEqual(0, list.ValueAt(0));
//        Assert.AreEqual(1, list.ValueAt(1));
//        Assert.AreEqual(3, list.ValueAt(2));
//        Assert.AreEqual(2, list.ValueAt(3));

//        list.Erase(1);
//        Assert.AreEqual(0, list.ValueAt(0));
//        Assert.AreEqual(3, list.ValueAt(1));
//        Assert.AreEqual(2, list.ValueAt(2));

//        list.Reverse();
//        Assert.AreEqual(2, list.ValueAt(0));
//        Assert.AreEqual(3, list.ValueAt(1));
//        Assert.AreEqual(0, list.ValueAt(2));

//        Assert.IsTrue(list.RemoveValue(3));
//        Assert.AreEqual(2, list.ValueAt(0));
//        Assert.AreEqual(0, list.ValueAt(1));

//        Assert.AreEqual(0, list.PopBack());
//        Assert.AreEqual(2, list.PopFront());
//        Assert.IsTrue(list.Empty());
//    }

//    [Test]
//    public void StringTypeTest_ShouldWorkWithNonIntegerTypes()
//    {
//        LinkedList<string> stringList = new LinkedList<string>();

//        stringList.PushBack("hello");
//        stringList.PushBack("world");

//        Assert.AreEqual("hello", stringList.Front());
//        Assert.AreEqual("world", stringList.Back());
//        Assert.AreEqual(2, stringList.Size());

//        Assert.IsTrue(stringList.RemoveValue("hello"));
//        Assert.AreEqual("world", stringList.Front());
//    }

//    [Test]
//    public void ObjectTypeTest_ShouldWorkWithCustomTypes()
//    {
//        // Test that the list works with a custom class
//        LinkedList<TestObject> objList = new LinkedList<TestObject>();

//        TestObject obj1 = new TestObject(1);
//        TestObject obj2 = new TestObject(2);

//        objList.PushBack(obj1);
//        objList.PushBack(obj2);

//        Assert.AreEqual(obj1, objList.Front());
//        Assert.AreEqual(obj2, objList.Back());

//        TestObject obj3 = new TestObject(1);  // Same value as obj1 but different instance
//        Assert.IsTrue(objList.RemoveValue(obj3));  // Should work with Equals implementation
//        Assert.AreEqual(obj2, objList.Front());
//    }

//    private class TestObject
//    {
//        public int Value { get; }

//        public TestObject(int value)
//        {
//            Value = value;
//        }

//        public override bool Equals(object obj)
//        {
//            if (obj is TestObject other)
//            {
//                return Value == other.Value;
//            }
//            return false;
//        }

//        public override int GetHashCode()
//        {
//            return Value.GetHashCode();
//        }
//    }
//}