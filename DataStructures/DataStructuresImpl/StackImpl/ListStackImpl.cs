namespace DataStructures.DataStructuresImpl.StackImpl
{
    public class ListStackImpl<T>
    {
        private LinkedList<T> list;

        public ListStackImpl()
        {
            Stack<T> stack = new();
            list = new LinkedList<T>();
        }

        public int Size() => list.Count;

        public bool IsEmpty() => list.Count == 0;

        public void Push(T item)
        {
            list.AddLast(item);
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Pop from empty stack");
            }

            T item = list.Last!.Value;
            list.RemoveLast();
            return item;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Peek from empty stack");
            }

            return list.Last!.Value;
        }
    }
}
