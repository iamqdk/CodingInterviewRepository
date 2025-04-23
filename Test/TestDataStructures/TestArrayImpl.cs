using DataStructures.DataStructuresImpl;

namespace TestDataStructures;

public class Tests
{
    [Test]
    public void DoublyLinkedList()
    {
        var doublyLinkedList = new DoublyLinkedListImpl();
        doublyLinkedList.AddLast(1);
        doublyLinkedList.AddLast(2);
        doublyLinkedList.AddLast(3);
        doublyLinkedList.AddLast(4);
        doublyLinkedList.AddLast(5);

        doublyLinkedList.AddLast(6);
    }
}
