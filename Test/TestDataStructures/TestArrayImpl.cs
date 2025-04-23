using DataStructures.DataStructuresImpl;

namespace TestDataStructures;

public class Tests
{
    [Test]
    public void Test_PushOrAdd()
    {
        ArrayImpl array = new ArrayImpl();
        Assert.That(array.Size(), Is.EqualTo(0));
        Assert.That(array.Capacity(), Is.EqualTo(0));
        Assert.IsTrue(array.IsEmpty());
        
        int capacity = 5;
        array = new ArrayImpl(capacity);
        Assert.That(array.Size(), Is.EqualTo(0));
        Assert.That(array.Capacity(), Is.EqualTo(5));
        Assert.IsTrue(array.IsEmpty());
        
        array.PushOrAdd(11);
        array.PushOrAdd(12);
        array.PushOrAdd(13);

        Assert.IsFalse(array.IsEmpty());
        Assert.That(array.Size(), Is.EqualTo(3));
        
        Assert.That(array.AtIndex(0), Is.EqualTo(11));
        Assert.That(array.AtIndex(1), Is.EqualTo(12));
        Assert.That(array.AtIndex(2), Is.EqualTo(13));

        Assert.Catch<IndexOutOfRangeException>(() => array.AtIndex(5));
        
        array.PushOrAdd(14);
        array.PushOrAdd(15);
        Assert.That(array.AtIndex(3), Is.EqualTo(14));
        Assert.That(array.AtIndex(4), Is.EqualTo(15));

        array.PushOrAdd(16);
        Assert.That(array.Size(), Is.EqualTo(6));
        Assert.That(array.Capacity(), Is.EqualTo(capacity * 2));
        Assert.That(array.AtIndex(5), Is.EqualTo(16));
    }

    [Test]
    public void Test_AtIndex_Exception()
    {
        ArrayImpl array = new ArrayImpl(5);
        array.PushOrAdd(11);
        array.PushOrAdd(12);
        array.PushOrAdd(13);

        Assert.Catch<IndexOutOfRangeException>(() => array.AtIndex(5));
        Assert.Catch<IndexOutOfRangeException>(() => array.AtIndex(-1));
    }

    [Test]
    public void Test_AtIndex_NoException()
    {
        ArrayImpl array = new ArrayImpl(5);
        array.PushOrAdd(11);
        array.PushOrAdd(12);
        array.PushOrAdd(13);
        
        Assert.That(array.AtIndex(0), Is.EqualTo(11));
        Assert.That(array.AtIndex(1), Is.EqualTo(14));
        Assert.That(array.AtIndex(2), Is.EqualTo(12));
    }

    [Test]
    public void Test_Pop()
    {
        int capacity = 5;
        var array = new ArrayImpl(capacity);
        Assert.That(array.Size(), Is.EqualTo(0));
        Assert.That(array.Capacity(), Is.EqualTo(5));
        Assert.IsTrue(array.IsEmpty());
        
        array.PushOrAdd(11);
        array.PushOrAdd(12);
        array.PushOrAdd(13);
        
        Assert.IsFalse(array.IsEmpty());
        Assert.That(array.Size(), Is.EqualTo(3));

        Assert.That(array.Pop(), Is.EqualTo(13));
        Assert.That(array.Size(), Is.EqualTo(2));
        Assert.That(array.AtIndex(2), Is.Null);

        Assert.That(array.Pop(), Is.EqualTo(12));
        Assert.That(array.Size(), Is.EqualTo(1));
        Assert.That(array.AtIndex(1), Is.Null);

        Assert.That(array.Pop(), Is.EqualTo(11));
        Assert.That(array.Size(), Is.EqualTo(0));
        Assert.That(array.AtIndex(0), Is.Null);

        Assert.Catch<IndexOutOfRangeException>(() => array.Pop());
    }
}
