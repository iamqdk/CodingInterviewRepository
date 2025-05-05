namespace DataStructures.Common
{
    class Node<T>
    {
        public T Val;
        public Node<T> Next;

        public Node(T val, Node<T> next = null)
        {
            Val = val;
            Next = next;
        }
    }
}
