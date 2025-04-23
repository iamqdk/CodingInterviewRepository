using System.Collections;

namespace DataStructures.DataStructuresImpl
{
    public class DoublyLinkedListImpl : IEnumerable
    {
        public class Node
        {
            private int _data;
            private Node _prev;
            private Node _next;

            public int Data
            {
                get => _data;
                set => _data = value;
            }

            public Node Prev
            {
                get => _prev;
                set => _prev = value;
            }

            public Node Next
            {
                get => _next;
                set => _next = value;
            }

            public Node(int data, Node prev, Node next)
            {
                _data = data;
                _prev = prev;
                _next = next;
            }

            public override string ToString()
            {
                return _data.ToString();
            }
        }

        private int _size = 0;
        private Node _head;
        private Node _tail;

        public int Size() => _size;

        public bool IsEmpty() => Size() == 0;

        /// <summary>
        /// O(N)
        /// </summary>
        public void Clear()
        {
            Node? trav = _head;
            while (trav != null)
            {
                Node next = trav.Next;
                trav.Prev = trav.Next = null;
                trav.Data = 0;

                trav = next;
            }

            _head = _tail = null;
            _size = 0;
        }

        /// <summary>
        /// O(1)
        /// </summary>
        public void AddLast(int data)
        {
            if(IsEmpty())
            {
                _head = _tail = new Node(data, null, null);
            }
            else
            {
                _tail.Next = new Node(data, null, null);
                _tail = _tail.Next;
            }

            _size++;
        }

        /// <summary>
        /// O(1)
        /// </summary>
        public void AddFirst(int data)
        {
            if (IsEmpty())
            {
                _head = _tail = new Node(data, null, null);
            }
            else
            {
               _head.Prev = new Node(data, null, _head);
                _head = _head.Prev;
            }

            _size++;
        }

        /// <summary>
        /// O(1)
        /// </summary>
        public int PeekFirst()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The list is empty.");
            }

            return _head.Data;
        }

        /// <summary>
        /// O(1)
        /// </summary>
        public int PeekLast()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The list is empty.");
            }

            return _tail.Data;
        }

        /// <summary>
        /// O(1)
        /// </summary>
        public int RemoveFirst()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The list is empty.");
            }

            int data = _head.Data;

            _head = _head.Next;
            _size--;

            if (IsEmpty())
            {
                _tail = null;
            }
            else
            {
                _head.Prev = null;
            }

            return data;
        }

        /// <summary>
        /// O(1)
        /// </summary>
        public int RemoveLast()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The list is empty.");
            }

            int data = _tail.Data;

            _tail = _tail.Prev;
            _size--;

            if (IsEmpty())
            {
                _head = null;
            }
            else
            {
                _tail.Next = null;
            }

            return data;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    
}
