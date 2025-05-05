//using System;

//public class LinkedListImpl<T>
//{
//    private class Node
//    {
//        public T Data { get; set; }
//        public Node Next { get; set; }

//        public Node(T data)
//        {
//            Data = data;
//            Next = null;
//        }
//    }

//    private Node _head;
//    private Node _tail;
//    private int _count;

//    public LinkedListImpl()
//    {
//        _head = null;
//        _tail = null;
//        _count = 0;
//    }

//    // Returns the number of data elements in the list
//    public int Size()
//    {
//        return _count;
//    }

//    // Returns true if empty
//    public bool Empty()
//    {
//        return _count == 0;
//    }

//    // Returns the value of the nth item (starting at 0 for first)
//    public T ValueAt(int index)
//    {
//        if (index < 0 || index >= _count)
//            throw new IndexOutOfRangeException("Index is out of range");

//        Node current = _head;
//        for (int i = 0; i < index; i++)
//        {
//            current = current.Next;
//        }

//        return current.Data;
//    }

//    // Adds an item to the front of the list
//    public void PushFront(T value)
//    {
//        Node newNode = new Node(value);

//        if (Empty())
//        {
//            _head = newNode;
//            _tail = newNode;
//        }
//        else
//        {
//            newNode.Next = _head;
//            _head = newNode;
//        }

//        _count++;
//    }

//    // Remove the front item and return its value
//    public T PopFront()
//    {
//        if (Empty())
//            throw new InvalidOperationException("Cannot pop from an empty list");

//        T value = _head.Data;
//        _head = _head.Next;
//        _count--;

//        if (_count == 0)
//            _tail = null;

//        return value;
//    }

//    // Adds an item at the end
//    public void PushBack(T value)
//    {
//        Node newNode = new Node(value);

//        if (Empty())
//        {
//            _head = newNode;
//            _tail = newNode;
//        }
//        else
//        {
//            _tail.Next = newNode;
//            _tail = newNode;
//        }

//        _count++;
//    }

//    // Removes end item and returns its value
//    public T PopBack()
//    {
//        if (Empty())
//            throw new InvalidOperationException("Cannot pop from an empty list");

//        T value = _tail.Data;

//        if (_count == 1)
//        {
//            _head = null;
//            _tail = null;
//        }
//        else
//        {
//            Node current = _head;
//            while (current.Next != _tail)
//            {
//                current = current.Next;
//            }

//            _tail = current;
//            _tail.Next = null;
//        }

//        _count--;
//        return value;
//    }

//    // Get the value of the front item
//    public T Front()
//    {
//        if (Empty())
//            throw new InvalidOperationException("List is empty");

//        return _head.Data;
//    }

//    // Get the value of the end item
//    public T Back()
//    {
//        if (Empty())
//            throw new InvalidOperationException("List is empty");

//        return _tail.Data;
//    }

//    // Insert value at index, so the current item at that index is pointed to by the new item at the index
//    public void Insert(int index, T value)
//    {
//        if (index < 0 || index > _count)
//            throw new IndexOutOfRangeException("Index is out of range");

//        if (index == 0)
//        {
//            PushFront(value);
//            return;
//        }

//        if (index == _count)
//        {
//            PushBack(value);
//            return;
//        }

//        Node newNode = new Node(value);
//        Node current = _head;

//        for (int i = 0; i < index - 1; i++)
//        {
//            current = current.Next;
//        }

//        newNode.Next = current.Next;
//        current.Next = newNode;
//        _count++;
//    }

//    // Removes node at given index
//    public void Erase(int index)
//    {
//        if (index < 0 || index >= _count)
//            throw new IndexOutOfRangeException("Index is out of range");

//        if (index == 0)
//        {
//            PopFront();
//            return;
//        }

//        Node current = _head;
//        for (int i = 0; i < index - 1; i++)
//        {
//            current = current.Next;
//        }

//        // If removing the last element, update tail
//        if (current.Next == _tail)
//        {
//            _tail = current;
//        }

//        current.Next = current.Next.Next;
//        _count--;
//    }

//    // Returns the value of the node at the nth position from the end of the list
//    public T ValueNFromEnd(int n)
//    {
//        if (n < 0 || n >= _count)
//            throw new IndexOutOfRangeException("n is out of range");

//        return ValueAt(_count - n - 1);
//    }

//    // Reverses the list
//    public void Reverse()
//    {
//        if (_count <= 1)
//            return;

//        _tail = _head;
//        Node prev = null;
//        Node current = _head;
//        Node next = null;

//        while (current != null)
//        {
//            next = current.Next;
//            current.Next = prev;
//            prev = current;
//            current = next;
//        }

//        _head = prev;
//    }

//    // Removes the first item in the list with this value
//    public bool RemoveValue(T value)
//    {
//        if (Empty())
//            return false;

//        if (_head.Data.Equals(value))
//        {
//            PopFront();
//            return true;
//        }

//        Node current = _head;
//        while (current.Next != null && !current.Next.Data.Equals(value))
//        {
//            current = current.Next;
//        }

//        if (current.Next != null)
//        {
//            if (current.Next == _tail)
//            {
//                _tail = current;
//            }

//            current.Next = current.Next.Next;
//            _count--;
//            return true;
//        }

//        return false;
//    }
//}